
# Coding Tracker

A Console application developed with Visual Studio using C# and SQLite.

This application allows users to track the amount of time they spend coding or generally working on programming projects.


## Features

- Local SQLite Database connection and manipulation using Dapper

- Clean and Functional UI with Spectre Console
    - User can use arrow keys and enter to navigate most menus.
    - Inputting dates is restricted to a specific format (mm/dd/yyyy hh:mm:ss) and informs user if input isn't valid.

- CRUD Database functions
    - Users are able to create new coding session entries and view, edit, and delete existing ones.



## Tech Stack

**Runtime & Framework:** .NET 9

**Database:** SQLite

**ORM / Micro-ORM:** Dapper

**UI:** Spectre.Console


## Lessons Learned

- I discovered the wonderful world of auto properties. Very simple, I know, but this feature helped to keep the CodingSession class very clean while still keeping the class's data protected.

- This was the first project I properly used App.config, specifically to handle the connection string and path of my database file. What originally sent me down a rabbit hole of what other use-cases App.config had, I ended up discovering that this has since been replaced with Appsettings.json. For this project, I installed a needed nuGet package in order to enable the App.config functionality to meet this project's requirements, but will be looking further into the newer standard for future projects.

- Dapper made interfacing with the database absolutely painless. With it, I also was able to implement dynamic parameters which helped with creating a few methods in the DatabaseUtilities class that could universally be used to run queries. Amongst other things, I really enjoyed using Dapper to even further simplify ADO.NET.
## Acknowledgements

 - [The C# Academy](https://www.thecsharpacademy.com/) - Amazing community that's paving the path for others to more easily learn how to use the .NET Framework and beyond.
 - [README Editor](https://readme.so/editor) - Great tool for structuring a README!
 - [Spectre Console](https://spectreconsole.net) - This made creating a console app a lot more painless. Fantastic tool!
 - [Dapper](https://www.learndapper.com) - Stellar ORM. Light and easy to use.

