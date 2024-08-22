using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using project.Models.ViewModels;
using project.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Humanizer;
using project.Models.Extension;
using Microsoft.EntityFrameworkCore;
using project.Models.Data;
using Microsoft.AspNetCore.Authorization;


namespace project.Controllers
{
	public class AccountController : Controller
	{
        #region Ctor
        private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
     

        

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }


        #endregion

        #region Logout
        [HttpPost]
		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
        #endregion

        #region Login
        public IActionResult Login(string? returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    
                    var redirectUrl = Url.IsLocalUrl(returnUrl) ? returnUrl : Url.Action("Index", "Home");
                    return Redirect(redirectUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }

            
            ViewBag.ReturnUrl = returnUrl;
            return View(model);
        }

        #endregion

        #region Registration
        public IActionResult Registration(string? returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegisterViewModel model, string? returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FullName = model.FullName // Set the FullName
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    if (!_userManager.Users.Any())
                    {
                        if (!await _roleManager.RoleExistsAsync("Admin"))
                        {
                            await _roleManager.CreateAsync(new IdentityRole("Admin"));
                        }
                        await _userManager.AddToRoleAsync(user, "Admin");
                    }
                    else
                    {
                        if (!await _roleManager.RoleExistsAsync("User"))
                        {
                            await _roleManager.CreateAsync(new IdentityRole("User"));
                        }
                        await _userManager.AddToRoleAsync(user, "User");
                    }

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    
                    var redirectUrl = Url.IsLocalUrl(returnUrl) ? returnUrl : Url.Action("Index", "Home");
                    return Redirect(redirectUrl);
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            ViewBag.ReturnUrl = returnUrl;
            return View(model);
        }


        #endregion

        #region EditProfile

        [HttpGet]
        public async Task<IActionResult> EditProfile()
        {
            try
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return NotFound();
                }

                var model = new EditProfileViewModel
                {
                    FullName = user.FullName,
                    BirthDate = user.BirthDate ?? DateTime.MinValue,
                    Address = user.Address,
                    City = user.City,
                    State = user.State,
                    PostalCode = user.PostalCode,
                    Country = user.Country,
                    PhoneNumber = user.PhoneNumber,
                    ExistingPhotoPath = user.Photo != null ? Convert.ToBase64String(user.Photo) : null
                };

                if (Request.IsAjaxRequest())
                {
                    return PartialView("_EditProfilePartial", model);
                }

                return View(model);
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, "An error occurred while loading the profile data.");
            }
        }



        [HttpPost]
        public async Task<IActionResult> EditProfile(EditProfileViewModel model)
        {
           

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }

            user.FullName = model.FullName;
            user.BirthDate = model.BirthDate;
            user.Address = model.Address;
            user.City = model.City;
            user.State = model.State;
            user.PostalCode = model.PostalCode;
            user.Country = model.Country;
            user.PhoneNumber = model.PhoneNumber;

            if (model.Photo != null && model.Photo.Length > 0)
            {
                using (var stream = new MemoryStream())
                {
                    await model.Photo.CopyToAsync(stream);
                    user.Photo = stream.ToArray();
                }
            }

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return Json(new { success = true });
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return PartialView("_EditProfilePartial", model);
        }



        #endregion

        #region AssignRole
        [Authorize(Roles = "Admin")]
        [HttpGet]

        public IActionResult AssignRole()
        {
            var users = _userManager.Users.ToList();
            var roles = _roleManager.Roles.Select(r => r.Name).ToList();

            var model = new Tuple<IEnumerable<IdentityUser>, IEnumerable<string>>(users, roles);

            return View(model);
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
		public async Task<IActionResult> AssignRole(string userId, string roleName)
		{
			var user = await _userManager.FindByIdAsync(userId);

			if (user == null)
			{
				ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
				return View("NotFound");
			}

			var roleExists = await _roleManager.RoleExistsAsync(roleName);

			if (!roleExists)
			{
				ViewBag.ErrorMessage = $"Role with Name = {roleName} cannot be found";
				return View("NotFound");
			}

			var isInRole = await _userManager.IsInRoleAsync(user, roleName);

			if (!isInRole)
			{
				var result = await _userManager.AddToRoleAsync(user, roleName);

				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}

				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
				}
			}

			return RedirectToAction("Index", "Home");
		}
        #endregion

        #region userWithRole

        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> UsersWithRoles()
		{
			var usersWithRoles = new List<UserWithRolesViewModel>();

			var users = _userManager.Users.ToList();

			foreach (var user in users)
			{
				var roles = await _userManager.GetRolesAsync(user);

				var userWithRoles = new UserWithRolesViewModel
				{
					UserId = user.Id,
					UserName = user.UserName,
					Roles = roles.ToList()
				};

				usersWithRoles.Add(userWithRoles);
			}

			return View(usersWithRoles);
		}
        #endregion

        #region AccessDenied
        public IActionResult AccessDenied()
		{
			return View();
		}
        #endregion

        #region ProfileView

        public async Task<IActionResult> ProfileView(string userId)
        {
            var user = _userManager.Users
        .Include(u => u.Books)
        .FirstOrDefault(u => u.Id == userId);

            if (user == null)
            {
                return NotFound();
            }

            
            var reviews = _context.Reviews
                .Include(r => r.Book) 
                .Where(r => r.UserId == userId) 
                .Select(r => new ReviewViewModel
                {
                    BookId = r.Book.BookId,
                    BookTitle = r.Book.Title,
                    Rating = r.Rating,
                    Comment = r.Comment,
                    DatePosted = r.DatePosted,
                    BookPhotoUrl = r.Book.PhotoUrl 
                })
                .ToList();

            double averageRating = reviews.Any() ? reviews.Average(r => r.Rating) : 0;

            var viewModel = new ProfileViewModel
            {
                FullName = user.FullName,
                Email = user.Email,            
                PhotoUrl = user.Photo != null ? $"data:image/jpeg;base64,{Convert.ToBase64String(user.Photo)}" : "/uploads/images (2).jpg",
                Address = user.Address,
                City = user.City,
                State = user.State,
                PostalCode = user.PostalCode,
                Country = user.Country,
                BooksPublished = user.Books.Count,
                ReviewsWritten = reviews.Count,
                AverageRating = averageRating,
                Reviews = reviews
                
            };

            return View(viewModel);
        }
        #endregion
    }
}
