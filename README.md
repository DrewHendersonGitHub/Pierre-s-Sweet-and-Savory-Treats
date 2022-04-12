# _Pierre's Flavor and Treats website_

### _By Drew Henderson_

#### _This website lets users view treats and flavors and login to add their own._

## Technologies Used

* _C#_
* _.NET_
* _cshtml_
* _Entity Framework_
* _MySQL_
* _css_
* _Bootstrap_

## Description

_This application uses a many-to-many database relationship between Flavors and Treats. Users can edit the contents of them if they are logged in using authentication._

## Setup/Installation Requirements

* _Make sure you have [.NET 5 SDK](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) and [MySQL Workbench](https://dev.mysql.com/downloads/mysql/) installed._
* _Install dotnet-ef if you haven't yet with ```dotnet tool install --global dotnet-ef```._
* _Download or clone ```https://github.com/DrewHendersonGitHub/Pierre-s-Sweet-and-Savory-Treats``` to your computer._
* _In a terminal inside directory ```Bakery```, make a new file ```appsettings.json```._
* _Add the following code with ```{DATABASE}```, ```{USERNAME}```, and ```{PASSWORD}``` replaced with your choice._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database={DATABASE};uid={USERNAME};pwd={PASSWORD};"
  }
}
```
* _Run `dotnet ef database update` inside the ```Factory``` directory to build your database._
* _Run ```dotnet restore``` and ```dotnet run``` in your terminal to build the project and open a local server._
* _CTRL click on the first listed URL, likely to be ```http://localhost:5000/```._

## Known Bugs

* _No known bugs at this time._

## License

[MIT](https://opensource.org/licenses/MIT)

_Copyright (c) 2022  Drew Henderson_