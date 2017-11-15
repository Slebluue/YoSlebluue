# Slebluue ASP.NET CORE 1.1 Scaffolding
One of many C# ASP.NET Core - Yeoman Generators
******
Generator built to offer a very simple project layout and starting place.
Offers the ability to toggle usage of the following front-end packages/frameworks:
 - Bootstrap
 - jQuery
 - jQuery Validation

### Repurposed
The original version of this was created for simple scaffolding of a ASP.NET Core project. 
It has been updated to include a login/registration off the bat as well as a success login
page where the other necessary code can be started.

Original Version: https://github.com/Serghar/CANDYMAN

Original Author: https://github.com/Serghar

### Usage
Install: ```npm install -g generator-slebluue```

Run ```yo slebluue```, optionally passing an app name
```
yo candyman [app=name]
```

Once installed navigate into newly created folder and run ```dotnet restore```

This specific instance is created to integrate with PostGres.
Navigate to appsettings.json and change your connection info accordingly.
After settings are updated run:
```
dotnet ef migrations add FirstMigration
```
```
dotnet ef database update
```

### License

MIT

------
Originially built for student use at Coding Dojo bootcamp
