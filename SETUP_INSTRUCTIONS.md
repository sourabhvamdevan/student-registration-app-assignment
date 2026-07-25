

Setup Instructions

Follow these step-by-step instructions to set up, configure, and run the Student Registration Web App locally using Visual Studio Code.

Prerequisites

Ensure you have the following software installed on your development machine:

* .NET SDK (Compatible with .NET 8 or .NET 9)


* Visual Studio Code


* C# Dev Kit extension (official extension for project management and debugging in VS Code)



Step 1: Clone the Repository

Open your terminal or command prompt, clone the repository from GitHub, and navigate into the project directory:

git clone [https://github.com/sourabhvamdevan/student-registration-app-assignment.git](https://www.google.com/search?q=https://github.com/sourabhvamdevan/student-registration-app-assignment.git)
cd student-registration-app-assignment

Step 2: Install Entity Framework Core CLI Tools

To run database migrations and update schemas, ensure you have the dotnet-ef tool installed globally on your system:

dotnet tool install --global dotnet-ef

(If it is already installed, you can skip this step or update it using dotnet tool update --global dotnet-ef).

Step 3: Restore NuGet Dependencies

Restore all required packages (such as Entity Framework Core providers and ASP.NET Core Identity packages) specified in the project:

dotnet restore

Step 4: Configure and Apply Database Migrations

The project uses an SQLite database configured via Entity Framework Core. Run the following command to apply pending migrations and generate the local database file (student_registration.db):

dotnet ef database update

Step 5: Run the Application

Start the local development server using the .NET watch command for live reloading during changes:

dotnet watch run

Once running, open your web browser and navigate to the local development URL displayed in your terminal (typically https://localhost:5001 or http://localhost:5000).

Step 6: Verify and Use the App

1. Authentication:


* Click Register in the top-right corner of the application to create a new user account.


* If the navigation menu only displays standard links, you can navigate directly to the login page via /Identity/Account/Login.




2. Student Management:


* Log in with your registered credentials.


* Access /Students/Create to register new student details.


* Access /Students/Index to view, manage, or delete registered student entries.
