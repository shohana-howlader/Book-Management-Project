
## Book Management Project

This is a Book Management application built using ASP.NET Core MVC and .NET 8. The project includes features for managing books, reviews, and user roles. It is designed to be a comprehensive system for handling book-related data with a focus on user interactions and data management.

## Features

- **User Authentication & Role Management**: Integrated with Microsoft.AspNetCore.Identity for secure user registration, login, and role assignment.
- **Book Management**: Add, edit, and manage book details with ease.
- **Review System**: Users can submit, edit, and delete reviews. Ratings and comments are linked to specific books and users.
- **Profile Management**: Users can update their profiles with personal information, including photos, contact details, and more.
- **Responsive Design**: The UI is built with Bootstrap, ensuring a responsive and user-friendly interface.

## Admin and User Credentials

- **Admin**
  - Email: `Admin@gmail.com`
  - Password: `Admin1234`

- **User**
  - Email: user@gmail.com
  - Password: User1234

### Admin Credentials

- **Email**: 
  ```plaintext
  Admin@gmail.com


## Technologies Used

- **ASP.NET Core MVC**
- **.NET 8**
- **Entity Framework Core**
- **Microsoft.AspNetCore.Identity**
- **Bootstrap 4.0**

## Getting Started

1. Clone the repository:

   ```bash
   https://github.com/shohana-howlader/Book-Management-Project.git
   ```

2. Navigate to the project directory and open it in Visual Studio.

3. Set up the database:

   - Update the `appsettings.json` file with your database connection string.
   - Run the following command to apply migrations and seed the database:

     ```bash
     dotnet ef database update
     ```

4. Run the application:

   ```bash
   dotnet run
   ```

5. Open a browser and navigate to `https://localhost:{port}` to view the application.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License

This project is licensed under the MIT License.
