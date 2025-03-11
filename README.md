# CRUD Task

## Project Overview
This is a simple ASP.NET Core MVC application for managing products. It allows users to perform CRUD (Create, Read, Update, Delete) operations on products stored in a database.

## Features
- Add new products with name, price, and quantity.
- List all available products.
- Edit existing product details.
- Delete products from the database.
- Client-side validation for product inputs.

## Technologies Used
- **ASP.NET Core MVC** - Web framework
- **Entity Framework Core** - ORM for database interaction
- **SQL Server** - Database
- **Bootstrap** - UI styling
- **C#** - Backend programming language

## Setup Instructions
### Prerequisites
Ensure you have the following installed on your system:
- .NET SDK
- SQL Server
- Visual Studio or VS Code
- Git

### Installation Steps
1. Clone the repository:
   ```bash
   git clone <repository_url>
   cd CRUD_Task
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Set up the database:
   - Update the connection string in `appsettings.json`.
   - Apply migrations:
     ```bash
     dotnet ef database update
     ```

4. Run the application:
   ```bash
   dotnet run
   ```

## Folder Structure
```
CRUD_Task/
│── bin/
│── Controllers/        # Contains MVC controllers
│── Data/              # Database context and migrations (Ignored in Git)
│── Migrations/        # EF Core Migrations
│── Models/            # Application models
│── Views/             # Razor views for UI
│── wwwroot/           # Static files (CSS, JS, Images)
│── appsettings.json   # Configuration file (Ignored in Git)
│── Program.cs         # Application entry point
│── CRUD_Task.csproj   # Project file
│── .gitignore         # Ignored files configuration
```

## Git Ignore Configuration
The `.gitignore` file ensures that unnecessary files are not tracked. Key ignored files:
```
/Data/
/appsettings.json
/bin/
/obj/
```



## Contact
For any questions or contributions, feel free to reach out.

---
Happy coding! 🚀

