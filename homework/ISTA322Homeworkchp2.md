## Arnold Burnley




1. What is the difference between Visual Studio and Visual Studio Code?

Visual Studio is the traditional development environment for .Net apps and it has  alarge range of tools and features that may not be available
in Visual Studio COde. 

2. What is LocalDB?

A zero-configuration version of SQL Server that can be installed as part of the SQL Server Express edition.

3. What do these commands do?
dotnet new globaljson --sdk-version 3.1.101 --output FirstProject
dotnet new mvc --no-https --output FirstProject --framework netcoreapp3.1

The first command creates a folder named FirtProject and adds it to a file named global.json. The second command creates a new ASP.Net Core project.

4. What command do you use to build an ASP.NET project from the command line? What command

dotnet new mvc --no-https --output FirstProject --framework netcoreapp3.1
do you use to run the project?
5. What is the purpose of an endpoint?

Endpoints handle incoming requests. Endpoints that produce responses to requests are called actions. 

6. What is a controller?

A controller is a C# class that is dervied from the Microsoft.AspNetCore.Mvc.Controller class, the built in controller base class. 

7. Where are actions defined?

Actions are defined 
8. What is the purpose of the routing system?

A routing system is responsible for selceting the endpoint that will handle an HTTP request. 
A route is a rule that is used to decide how a request is handled. 

9. Assume that your ASP.NET application runs in a browser with a URL like http://localhost:5000.
List the three default routes configured by the ASP.NET Core routing system.

* /
* /Home
* /Home/Index

10. What does the ViewResult object instruct ASP.NET Core to do?
11. How does ASP.NET Core know what View is to be called from an action method?
12. What is the job of an action method?
13. What is a view model?
Page 1, Revised on July 7, 2020 by Charles Carter