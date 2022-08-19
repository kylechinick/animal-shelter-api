# ANIMAL SHELTER API

_Authored by Kyle Chinick_

API that holds a list of animals currently available for adoption at a fictional animal shelter.

## TECHNOLOGIES

- _C# / .NET 6.0_
- _Entity Framework Core_
- _CSHTML / RAZOR / LINQ_
- _Swagger / Swashbuckle_

## DESCRIPTION

The endpoints for this app can be reached through a web browser or an API platform like [Postman](https://www.postman.com/).

After launching the app, as described below, navigate to `http://localhost:5000/api/Animals/` in your browser or send the URL as a GET request in Postman to receive a list of all animals currently in the shelter.

You can refine your results by adding queries. For instance, a GET request with the path `http://localhost:5000/api/Animals/2` will return only the animal with an ID of 2.

Additionally, users can view API data through an auto-generated UI, built out by the tool Swagger, by navigating to `http://localhost:5000/swagger/index.html` in a browser. The Swagger-generated UI shows each endpoint as an interactive block that can be expanded to send actual CRUD reqests through the app instead of doing so through the browser URL or Postman.

### ENDPOINTS

Base URL: `https://localhost:5000/Animals`

#### HTTP REQUEST STRUCTURE

```Shell
GET /api/Animals
POST /api/Animals
GET /api/Animals/{id}
PUT /api/Animals/{id}
DELETE /api/Animals/{id}
```

#### EXAMPLE QUERY

```Shell
https://localhost:5000/api/Animals/2
```

#### EXAMPLE JSON RESPONSE

```JSON
{
  "animalId": 2,
  "name": "Bob",
  "species": "Panda",
  "age": 8,
  "gender": "Unknown"
}
```

## SETUP

1. Clone this repository to your desktop by running the following command in your preferred terminal application:

   ```Shell
   git clone https://github.com/kylechinick/animal-shelter-api.git
   ```

2. Install each required package by running the following terminal commands:

   ```Shell
   dotnet add package Microsoft.EntityFrameworkCore --version 6.0.8
   dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.8
   dotnet add package Microsoft.EntityFrameworkCore.Proxies --version 6.0.8
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.8
   dotnet add package Pomelo.EntityFrameworkCore.MySql --version 6.0.2
   dotnet add package Swashbuckle.AspNetCore.SwaggerGen --version 6.2.3
   dotnet add package Swashbuckle.AspNetCore.ApiTesting --version 6.4.0
   dotnet add package RestSharp --version 106.15.0
   dotnet add package Newtonsoft.Json --version 13.0.1
   ```

3. Create an _appsettings.json_ file in the project root and populate it with the following content, taking care to update with your unique database configurations:

   ```JSON
   {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=animal-shelter_api;uid=root;pwd=epicodus;"
    }
   }
   ```

   - NOTE: _[password]_ should be replaced by your password. Do not include square brackets in the final configuration.

4. Create a _.gitignore_ file in the project root and add the following items to be ignored:

   ```plain text
   */obj/
   */bin/
   */appsettings.json
   ```

5. Add, commit, and push the new _appsettings.json_ file on its own in order to prevent uploading the sensative info it contains to the public.

6. In the terminal, `cd` into the _/SweetAndSavoryExplorer/_ directory then execute the `dotnet restore` command to auto-populate the project with an _/obj/_ directory.

7. Execute `dotnet build` in the terminal to automatically create the required _/bin/_ folder for the project.

8. Update your database to reflect the provided migration data:
   `dotnet ef database update`

9. To run the app execute `dotnet run` from the project directory or, optionally, `dotnet watch run` to start the app and cause it to rebuild and run after each saved change to the codebase.

## BUGS

- N/A

## LICENSE

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2022 Kyle Chinick. All Rights Reserved.

> **MIT License**
> Copyright 2022 Kyle Chinick
>
> Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
>
> The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
>
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
