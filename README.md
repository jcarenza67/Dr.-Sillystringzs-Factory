# Dr. Sillystringz's Factory


#### By Joseph Wilfong

## Technologies Used

* _C#_
* _.NET SDK_
* _Razor_
* _Bootstrap_
* _CSS_
* _HTML_
* _ASP.NET Core_
* _Entity Framework Core_
* _MySQL_
* _MySQL Workbench_




## Description

__Dr. Sillystringz's Factory is a web application showcasing a many-to-many relationship between Engineers and Machines with MySQL databases_

## Links

[This is the link to the Github repository](https://github.com/jcarenza67/Dr.-Sillystringzs-Factory) 


## Setup/Installation Requirements

* _Click the green dropdown button above that says "Code"_
* _Copy the repository HTTPS, clone it to your Desktop directory by typing ***git clone***, paste the copied URL right after **clone**, and then press enter_
* _Open the file in your preferred code editor_
* _Make sure the following files are in your .gitignore file:_
* ***obj***
* ***bin***
* ***appsettings.json***
* _Then ***git add/push*** the .gitignore file ***separately*** to your repository_
* _Download ***.NET 6 SDK*** by following the directions from this link [Here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0), this will also allow you to use **C#**_
* _**Open the file**. This will launch an installer which will walk you through installation steps. ***Use default settings***._
* _Confirm the installation is successful by opening your terminal and running the command ***dotnet --version***._
```
6.0.402
```
* _Navigate to the ***Factory*** directory in your terminal_
* _Add the ***EF Core*** packages listed below by typing ***dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0*** and ***dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0*** in the terminal_
* _Then type ***dotnet build*** in your terminal to make sure everything is up to date and there are no errors_

## Configure Connection to the Database

* _Create a file named ***appsettings.json*** in the ***Factory*** directory and add the following code inside the file_
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=dr_silly_wilfong;uid=[YOUR-USERNAME];pwd=[YOUR-PASSWORD];"
  }
}
```

# Using Migrations

* _Navigate to the ***Factory*** directory in your terminal_
* _To create migrations, update your database, and use dotnet-ef type ***dotnet tool install --global dotnet-ef --version 6.0.0*** and ***dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0*** into your terminal_
* _In the terminal, type ***dotnet ef migrations add Initial*** to create a Migrations folder_
* _Then type ***dotnet ef database update*** to update your database_
* _Then launch the webpage by typing ***dotnet watch run*** in the teminal and a webpage should open in your browser, if not, enter the url ***https://localhost:5001/*** in your browser_
* _For issuing and trusting a security certificate, type ***dotnet dev-certs https --trust*** in the terminal and restart your browser_




***_Please contact me at josephwilfong91@gmail.com if you have any questions, ideas, or concerns._***


## Known Bugs

* _unknown_

## License


_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._

_Copyright (c) _2023_ _Joseph Wilfong_