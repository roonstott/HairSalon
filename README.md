# _Hair Salon_

#### By _Robert Onstott_

#### _Web-based small business application for keeping track of what stylists work within a hair salon, and what clients are signed up with each stylist_

## Technologies Used

* _C# and .NET 6.0_
* _ASP.NET core MVC_
* _Entity Framework Core_
* _MySQL community server_
* _MySQL Workbench_
* _VS Code_
* _Github_

## Description

_This web app is intended for a hypothetical client who runs a small hair salon. The client has multiple stylists working for them, and numerous clients who are signed up with each stylist. Using the ASP.NET core MVC web development framework, this app structures the client and stylist information as object classes with a many-to-one relationship between clients and stylists. All model information is stored in a SQL database._

## Setup/Installation Requirements

* _Download the .NET framework if you do not already have it (version 6.0 or later)_
 
  _https://dotnet.microsoft.com/en-us/download/dotnet_
  
* _Download MySQL Community Server and MySQL Workbench if you don't already have them (both from this link). Make note of both the `User ID (UID)` and the `Password (PWD)` that you define in your setup configurations for MySQL. These values will go into your `appsettings.json` file in a few steps_
  
    _https://dev.mysql.com/downloads/_
  
* _Clone this repository to your machine_

* _Open the repository (VS Code is recommended) and create a new file in the root directory called `appsettings.json`. Copy the following code into the file, with your own values for uid and pwd_
 
 `
  {
  
    "ConnectionStrings": {
    
      "DefaultConnection": "Server=localhost;Port=3306;database=robert_onstott;uid=[***your user ID here ***];pwd=[*** your password here *** ];"
      
    }
    
  }
  `
  
* _Open MySQL workbench and open local server 3306. Navigate to the Administration tab in the top left. Click the 6th icon down in the navigation bar 'Data Import/Restore'. Select 'Imort from Self Contained File' and select the robert_onstott.sql file in the root directory if this repository. The database is now being hosted on a local server on your machine_

* _Navigate to the HairSalon directory one level down from the root directory and enter the command $dotnet run. This will start the local web server. Enter the URL https://localhost:5001 in a browser window. You are now interacting with the web app_
  
  _`$ cd HairSalon`_
  
  _`$ dotnet run`_
  
  _https://localhost:5001_

## Known Bugs

* _No known bugs at this time_

## License

_MIT_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._

Copyright (c) _December 2022_ _Robert Onstott_
