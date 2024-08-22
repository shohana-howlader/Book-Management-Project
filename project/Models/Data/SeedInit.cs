using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace project.Models.Data
{
    public static class SeedInit
    {
        public static void SeedUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "19969177-ce23-40c5-a98f-208a1c9a05ef",
                FullName = "User2",
                BirthDate = new DateTime(2024, 1, 1),
                Address = "abc",
                City = "abc",
                State = "bcd",
                PostalCode = "123",
                Country = "Bangladesh",
                Photo = null,
                UserName = "User2@gmail.com",
                NormalizedUserName = "USER2@GMAIL.COM",
                Email = "User2@gmail.com",
                NormalizedEmail = "USER2@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEHv1KdCKO985DrAHiLzutzsyF3ChxBwbSHLownXFGpX3qYVGL5KKgdo/zpoYDvsaWw==",
                SecurityStamp = "RI3IW2VSX3UISEYXY3WD2GBTL6ZAZFTI",
                ConcurrencyStamp = "14802cd2-403f-4669-80fd-74c3f4ede2bd",
                PhoneNumber = "01544",
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            },
            new ApplicationUser
            {
                Id = "2b1e3262-3842-4928-bf88-c605d64a8f14",
                FullName = "Admin",
                BirthDate = null,
                Address = null,
                City = null,
                State = null,
                PostalCode = null,
                Country = null,
                Photo = null,
                UserName = "Admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "Admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEIudkMASgiIiA1gtEy3dVerFn+IkhFwd1Rx1Fy3X3kIKQzMx7S9IAXVUv2QTnjRmUg==",
                SecurityStamp = "Q56MFZAHV55EXRNH2357PVMTGWLBWDIK",
                ConcurrencyStamp = "570170d2-f8af-4583-a816-05a87c7e8cb9",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            },
            new ApplicationUser
            {
                Id = "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f",
                FullName = "User1",
                BirthDate = new DateTime(2024, 1, 1),
                Address = "abc",
                City = "abc",
                State = "bcd",
                PostalCode = "123",
                Country = "Bangladesh",
                Photo = null,
                UserName = "User1@gmail.com",
                NormalizedUserName = "USER1@GMAIL.COM",
                Email = "User1@gmail.com",
                NormalizedEmail = "USER1@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEOfpGy8NAXGelc3KcBVk+93VHpYKPAWo28bh5bkKHQy0smgaN5k0lH1OpTugouSpSg==",
                SecurityStamp = "5HHVN73BSWBGEGNCWRG6ZDZMDENLDCIA",
                ConcurrencyStamp = "3041498e-1f61-4b7e-a2da-6e4fcbc57ae7",
                PhoneNumber = "01544",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            },
            new ApplicationUser
            {
                Id = "5c830ccd-9837-4f09-87df-d2a20f4381ee",
                FullName = "User",
                BirthDate = new DateTime(2024, 1, 1),
                Address = "abc",
                City = "abc",
                State = "bcd",
                PostalCode = "123",
                Country = "Bangladesh",
                Photo = null,
                UserName = "user@gmail.com",
                NormalizedUserName = "USER@GMAIL.COM",
                Email = "user@gmail.com",
                NormalizedEmail = "USER@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEPh3UM1Y++PEJ26Pmr1dYcj4mPkCSgyNPG6kezWTZBnkMHCqZyDTS7PFNwovXtzpFQ==",
                SecurityStamp = "EB5FGW7BZSVQUR4RW2NOAOB6JEXWPHQS",
                ConcurrencyStamp = "c361b72d-91e5-4a45-ba1c-c9d940792944",
                PhoneNumber = "01544",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            },
            new ApplicationUser
            {
                Id = "b03879ae-7c13-4930-81c5-246258494f8e",
                FullName = "User3",
                BirthDate = null,
                Address = null,
                City = null,
                State = null,
                PostalCode = null,
                Country = null,
                Photo = null,
                UserName = "User3@gmail.com",
                NormalizedUserName = "USER3@GMAIL.COM",
                Email = "User3@gmail.com",
                NormalizedEmail = "USER3@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEAmbsG0eC93sFbGewaWDTVTBe/fL4ByxuqDAX7P63YX/0Iw6Xf3QyYWc6p7r2vV6fA==",
                SecurityStamp = "OZJKJK7CSLPN6UGAPFX67XB4N7SYS3MS",
                ConcurrencyStamp = "e013f754-1eb8-4d79-8365-2f2a4c2759f6",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            }
        );
        }


        public static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
             new IdentityRole
             {
                 Id = "6d13f88e-5381-48ec-9297-7bb3b757b48c",
                 Name = "User",
                 NormalizedName = "USER"
             },
             new IdentityRole
             {
                 Id = "a599c23e-da42-4921-a61c-38771b502d69",
                 Name = "Admin",
                 NormalizedName = "ADMIN"
             },
             new IdentityRole
             {
                 Id = "f1f0c962-2975-4358-b114-dd4f2e78445d",
                 Name = "Manager",
                 NormalizedName = "MANAGER"
             }
         );
        }

        public static void SeedUserRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string>
               {
                   UserId = "19969177-ce23-40c5-a98f-208a1c9a05ef",
                   RoleId = "6d13f88e-5381-48ec-9297-7bb3b757b48c"
               },
               new IdentityUserRole<string>
               {
                   UserId = "2b1e3262-3842-4928-bf88-c605d64a8f14",
                   RoleId = "6d13f88e-5381-48ec-9297-7bb3b757b48c"
               },
               new IdentityUserRole<string>
               {
                   UserId = "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f",
                   RoleId = "6d13f88e-5381-48ec-9297-7bb3b757b48c"
               },
               new IdentityUserRole<string>
               {
                   UserId = "5c830ccd-9837-4f09-87df-d2a20f4381ee",
                   RoleId = "6d13f88e-5381-48ec-9297-7bb3b757b48c"
               },
               new IdentityUserRole<string>
               {
                   UserId = "b03879ae-7c13-4930-81c5-246258494f8e",
                   RoleId = "6d13f88e-5381-48ec-9297-7bb3b757b48c"
               },
               new IdentityUserRole<string>
               {
                   UserId = "2b1e3262-3842-4928-bf88-c605d64a8f14",
                   RoleId = "a599c23e-da42-4921-a61c-38771b502d69"
               }
           );
        }

        public static void SeedBooks(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>()
               .HasKey(b => b.BookId);

            modelBuilder.Entity<Book>()
                .Property(b => b.BookId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Book>().HasData(
                new Book
                {

                    Title = "Roktatto Prantor",
                    Author = "Munir Choudhury",
                    Genre = "Golpo",
                    PublishedDate = new DateTime(2024, 1, 1),
                    PhotoUrl = "/uploads/37f29045-ba2e-4f1a-9f55-9ca3842b55fd_Roktakto-Prantor-By-Monier-Choudhury.jpg",
                    UserId = "4",
                    Description = "Paragraphs are the building blocks of papers..."
                },
                new Book
                {

                    Title = "Atomic Habits",
                    Author = "James Clear",
                    Genre = "Nonfiction",
                    PublishedDate = new DateTime(2024, 1, 1),
                    PhotoUrl = "/uploads/f03859fd-92b7-4ccf-8185-a231e2d6c761_OIP.jpeg",
                    UserId = "4",
                    Description = "Atomic Habits: An Easy & Proven Way to Build Good Habits..."
                },
                new Book
                {

                    Title = "Opekkha",
                    Author = "Humayun Ahmed",
                    Genre = "Novel",
                    PublishedDate = new DateTime(2024, 1, 1),
                    PhotoUrl = "/uploads/261142fe-313c-4457-9376-2efa141d5cef_OIP (1).jpeg",
                    UserId = "4",
                    Description = "Humayun's younger brother, Muhammed Zafar Iqbal..."
                },
                new Book
                {

                    Title = "The Moral Compass",
                    Author = "William J. Bennett",
                    Genre = "Novel",
                    PublishedDate = new DateTime(2024, 1, 1),
                    PhotoUrl = "/uploads/6c99f8ac-0e70-4fa3-a076-6bf9729f9489_download.png",
                    UserId = "3",
                    Description = "Explore moral compass and learn the definition..."
                },
                new Book
                {

                    Title = "Hada Voda Somogro",
                    Author = "Narayan Debnath",
                    Genre = "Comics",
                    PublishedDate = new DateTime(2024, 1, 1),
                    PhotoUrl = "/uploads/dd400bf0-dabe-40fa-80c0-9cfe72452d19_R.jpeg",
                    UserId = "3",
                    Description = "Hada Voda Somogro by Narayan Debnath is popular Bengali Book..."
                },
                new Book
                {

                    Title = "Shamali",
                    Author = "Rabindranath Tagore",
                    Genre = "Poem",
                    PublishedDate = new DateTime(2024, 1, 1),
                    PhotoUrl = "/uploads/51dac520-2a36-4c84-b120-aa249759d906_Shamali by Rabindranath Tagore - PDF Bangla Books.jpg",
                    UserId = "3",
                    Description = "Shamali by Rabindranath Tagore is a popular Bengali Novel..."
                },



                 new Book
                 {

                     Title = "কে কথা কয়",
                     Author = "হুমায়ুন আহমেড",
                     Genre = "Novel",
                     PublishedDate = new DateTime(2024, 1, 1),
                     PhotoUrl = "/uploads/6e2a20c8-53d8-4b3d-94c2-7ece32a43db3_Ke Kotha Koy by Humayun Ahmed PDF Bangla Books.jpg",
                     UserId = "1",
                     Description = "Ke Kotha Koi by Humayun Ahmed is a popular Bengali novel..."
                 },
                new Book
                {

                    Title = "ডোরা কাটা জামা",
                    Author = "সঞ্জীব চট্টোপাধ্যায়",
                    Genre = "উপন্যাস",
                    PublishedDate = new DateTime(2024, 1, 1),
                    PhotoUrl = "/uploads/Dorakata Jama by Sanjib Chattopadhyay pdf bangla Novel.jpg",
                    UserId = "1",
                    Description = "Dorakata Jama by Sanjib Chattopadhyay is a Popular Bengali Book..."
                },
                new Book
                {

                    Title = "Promila Golpo Songkolon",
                    Author = "Bijit Ghosh",
                    Genre = "Golpo",
                    PublishedDate = new DateTime(2024, 1, 1),
                    PhotoUrl = "/uploads/b31f67fe-2983-4df7-9928-cd35d4c1f8f7_Promila Golpo Songkolon edited by Bijit Ghosh PDF Bangla Story Collection.jpg",
                    UserId = "5",
                    Description = "Promila Golpo Songkolon edited by Bijit Ghosh is a collection of Short Stories..."
                }
            );
        }

        public static void SeedReviews(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(
               new Review
               {

                   BookId = 1,
                   UserId = "4",
                   Rating = 3,
                   Comment = "A good book for good life",
                   DatePosted = new DateTime(2024, 8, 21, 22, 15, 34)
               },
               new Review
               {

                   BookId = 2,
                   UserId = "4",
                   Rating = 5,
                   Comment = "Nice book of this era",
                   DatePosted = new DateTime(2024, 8, 21, 22, 16, 28)
               },
               new Review
               {

                   BookId = 2,
                   UserId = "3",
                   Rating = 3,
                   Comment = "A captivating journey through vivid characters and thought-provoking themes, this book leaves a lasting impression on the reader's mind",
                   DatePosted = new DateTime(2024, 8, 21, 22, 30, 40)
               },
               new Review
               {

                   BookId = 1,
                   UserId = "3",
                   Rating = 5,
                   Comment = "A captivating journey through vivid characters and thought-provoking themes, this book leaves a lasting impression on the reader's mind",
                   DatePosted = new DateTime(2024, 8, 21, 22, 30, 58)
               },
               new Review
               {

                   BookId = 3,
                   UserId = "3",
                   Rating = 4,
                   Comment = "A captivating journey through vivid characters and thought-provoking themes, this book leaves a lasting impression on the reader's mind",
                   DatePosted = new DateTime(2024, 8, 21, 22, 31, 07)
               },
               new Review
               {

                   BookId = 6,
                   UserId = "3",
                   Rating = 2,
                   Comment = "A captivating journey through vivid characters and thought-provoking themes, this book leaves a lasting impression on the reader's mind",
                   DatePosted = new DateTime(2024, 8, 21, 22, 31, 19)
               },
               new Review
               {

                   BookId = 1,
                   UserId = "1",
                   Rating = 3,
                   Comment = "good Books",
                   DatePosted = new DateTime(2024, 8, 21, 22, 43, 03)
               },
               new Review
               {

                   BookId = 1,
                   UserId = "5",
                   Rating = 5,
                   Comment = "a group of sentences or a single sentence that forms a unit",
                   DatePosted = new DateTime(2024, 8, 21, 22, 50, 51)
               }
           );
        }
    }
}
