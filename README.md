# The Road Taken; From Framework to .NET 8

## Presentation summary
Do you have a .NET Framework project out there that’s really looking to be updated to dotnet? Have a look at the path we chose when upgrading a production webshop running on WebForms with every imaginable anti pattern, into a modern framework with a MVC public site and a Blazor administration interface. On this trip we will go through subjects like analysis, planning, architecture, some best practices and what will you need to do to move it from on premise or Infrastructure As A Service to a fully managed Platform hosted solution.

## Speaker
- Eric Johansson, aka Thindal.

Back in 2003, I discovered .NET. Coming from a background of mostly using C++ for client- and PERL/ASP Classic for web-development, discovering and developing with .NET was like the clouds opening up and a ray of sunshine washing over me.
Since then, I've been working with .NET in various forms, from ASP.NET WebForms to ASP.NET MVC to ASP.NET 5+, from Windows Forms to WPF to UWP, from WCF to WebAPI to gRPC, from SQL Server to MongoDB to CosmosDB.
While I've dabbled with other languages and platforms since, .NET has been my home, and pulling me back in as my platform of choice.
Today, my day job is running a consulting firm specializing in .NET development and Azure architecture.
At other times, I run an open, inclusive and educational twitch stream helping people experience and learn .NET.

## The demo
The demo is a very simple example of a WebForms application, that we will upgrade to a modern .NET 8 application. We will go through the steps of upgrading the project from WebForms, into MVC5, and finally to ASP.NET on .NET8.
From here, the application will be packaged with Docker and prepared to be deployed to an Azure App Service.