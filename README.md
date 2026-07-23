

# Student Registration Web App

A secure full-stack web application built using **ASP.NET Core Razor Pages** and **ASP.NET Core Identity** for user authentication and authorization, utilizing an **SQLite** database for local development.

---

## Repository Link

* **GitHub Repository:** [sourabhvamdevan/student-registration-app-assignment](https://github.com/sourabhvamdevan/student-registration-app-assignment)

---

## Features

* **User Authentication:** Complete registration, login, and logout workflows powered by ASP.NET Core Identity.
* **Route Authorization:** Secured endpoints and Razor Pages (`/Students/Index`, `/Students/Create`) restricted to authenticated users only.
* **Student Management (CRUD):** Ability to register new student records (Full Name, Email, Department, Enrollment Year) and view the complete roster linked to user sessions.
* **Local Database Persistence:** Uses SQLite via Entity Framework Core with automated migrations.

---

## Tech Stack

* **Framework:** .NET 8 / .NET 9 (ASP.NET Core Razor Pages)
* **Security / Auth:** ASP.NET Core Identity
* **Database & ORM:** SQLite, Entity Framework Core
* **IDE:** Visual Studio Code (C# Dev Kit)

---

## Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/download) (matching your project version)
* [Visual Studio Code](https://code.visualstudio.com/)
* **C# Dev Kit** extension for VS Code
* Entity Framework Core Global Tool (`dotnet-ef`)

---

## Getting Started & Installation

### 1. Clone the Repository

Clone the project repository to your local machine:

```bash
git clone https://github.com/sourabhvamdevan/student-registration-app-assignment.git
cd student-registration-app-assignment

```

### 2. Install EF Core Tools (if not already installed)

Open the integrated terminal in VS Code (`Ctrl + ~`) and install the CLI tool globally:

```bash
dotnet tool install --global dotnet-ef

```

### 3. Restore Dependencies

Restore all NuGet packages required by the project:

```bash
dotnet restore

```

### 4. Apply Database Migrations

Create the SQLite database and run pending migrations to set up Identity and Student tables:

```bash
dotnet ef database update

```

### 5. Run the Application

Start the development server using the watch command for live reloading:

```bash
dotnet watch run

```

Open your browser and navigate to the local URL provided in the terminal (typically `https://localhost:5001` or `http://localhost:5000`).

---

## Usage Guide

* **Authentication:**
* Click **Register** in the top-right corner to create a new user profile.
* Click **Login** with your credentials. *(Note: If the navigation menu only displays Home and Privacy, you can navigate directly to `/Identity/Account/Login`)*.


* **Student Management:**
* Once logged in, navigate to `/Students/Create` to add a new student record.
* Access `/Students/Index` to view all registered students and manage records.



---

## Project Structure

```text
StudentRegistrationApp/
│
├── Data/
│   └── ApplicationDbContext.cs    # EF Core context managing Identity and Students
│
├── Models/
│   └── Student.cs                 # Student entity data model
│
├── Pages/
│   ├── Students/                  # Protected CRUD Razor Pages
│   │   ├── Create.cshtml          # Register new student form
│   │   └── Index.cshtml           # List of registered students
│   └── Shared/                    # Layout and validation scripts
│
├── appsettings.json               # Database connection strings & configuration
├── Program.cs                     # Service registration & middleware pipeline
└── student_registration.db        # SQLite database file (generated on migration)

```