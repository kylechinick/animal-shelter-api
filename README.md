# Animal Shelter API

Author: _**Kyle Chinick**_

API that holds a list of animals currently available for adoption at a fictional animal shelter.

## Technologies Used

- _C# / .NET 6.0_
- _Entity Framework Core_
- _CSHTML / RAZOR / LINQ_

## Description

The endpoints for this app can be reached through a web browser or an API platform like [Postman](https://www.postman.com/).

After launching the app, as described below, navigate to http://localhost:5000/api/Animals/ in your browser or send the URL as a GET request in Postman to receive a list of all animals currently in the shelter.

You can refine your search by adding queries. For instance, 

## Setup/Installation Requirements

1. Clone this repository to your desktop by running the following command in your preferred terminal application:

   ```Shell
   git clone https://github.com/kylechinick/animal-shelter-api.git
   ```

2. Install each required package by running the following terminal commands:

   ```Shell
   dotnet tool install --global dotnet-ef --version 6.0.0
   ```

   ```Shell
   dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
   ```

   ```Shell
   dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
   ```

   ```Shell
   dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 6.0.0
   ```

   ```Shell
   dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
   ```

   ```Shell
   dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 6.0.0
   ```

3. In the terminal, `cd` into the _/SweetAndSavoryExplorer/_ directory then execute the `dotnet restore` command to auto-populate the project with an _/obj/_ directory.

4. Create an _appsettings.json_ file in the project root and populate it with the following content, taking care to update with your unique database configurations:

   ```JSON
   {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=sase-db;uid=root;pwd=[YOUR PASSWORD];"
    }
   }
   ```

   - NOTE: _[password]_ should be replaced by your password. Do not include square brackets in the final configuration.

5. Create a _.gitignore_ file in the project root and add the following items to be ignored:

   ```plain text
   */obj/
   */bin/
   */appsettings.json
   ```

6. Add, commit, and push the new _appsettings.json_ file on its own in order to prevent uploading the sensative info it contains to the public.

7. Execute `dotnet build` in the terminal to automatically create the required _/bin/_ folder for the project.

8. Update your database to reflect the provided migration data:
   `dotnet ef database update`

   - NOTE: Repeat this steps 6 and 7, after updating _'Initial'_ to whichever name best represents your new migration any time a change is made to the database in the future.

9. To run the app execute `dotnet run` from the project directory or, optionally, `dotnet watch run` to start the app and cause it to rebuild and run after each saved change to the codebase.

## Known Bugs

- N/A
