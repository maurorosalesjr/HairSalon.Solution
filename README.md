# Stylist/Client Database

#### By Mauro Rosales jr

#### enables user to create a database that adds stylists and connects clients to those stylists. one to many database

## Technologies Used

* SQL
* MySQL
* VSCode
* C#
* HTML
* CSS

## Description

Enables user to create a database that allows for the shop owner to add stylists they hire and schedule clients to the stylists specialty

## Setup/Installation Requirements

* clone repo from https://github.com/maurorosalesjr/HairSalon
* using MySQL import database structure from mauro_rosales Folder
* create appsettings.json file to allow user to link MySQL (database) to this project 
* add this code to the appsettings.json file and add the missing information
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=[PORT];database=[DATABASE NAME];uid=[UID];pwd=[PASSWORD];"
  }
}
* make sure appsettings.json file is on the .gitignore file
* in terminal type : dotnet restore
* in terminal type : dotnet build
* in terminal type : dotnet run
* copy/paste : http://localhost:5000 into browser window
* use links to create and build out database



## Known Bugs

* CSS styling doesnt always load properly

## License

open source

for any questions or comments email me here: mauro.rosales247@gmail.com

Copyright (c) July 2022, Mauro Rosales Jr