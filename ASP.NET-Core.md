# ASP.NET Core

.NET Core is a new version of .NET Framework, which is a free, open-source, general-purpose development platform maintained by Microsoft. It is a cross-platform framework that runs on Windows, macOS, and Linux operating systems.

.NET Core Framework can be used to build different types of applications such as mobile, desktop, web, cloud, IoT, machine learning, microservices, game, etc.

# Why .NET Core
There are some limitations with the .NET Framework. For example, it only runs on the Windows platform.

# .NET Core Characteristics

> Cross-platform:
>* NET Core runs on Windows, macOS, and Linux operating systems. There are different runtime for each operating system that executes the code and generates the same output.

> Consistent across Architectures:
>* Execute the code with the same behavior in different instruction set architectures, including x64, x86, and ARM.

> Wide-range of Applications:
>* Various types of applications can be developed and run on .NET Core platform such as mobile, desktop, web, cloud, IoT, machine learning, game etc.

> Supports Multiple Languages:
>* You can use C# and Visual Basic programming languages to develop .NET Core applications. You can use your favorite IDE, including Visual Studio, Visual Studio Code etc.

> Modular Architecture:
>* .NET Core supports modular architecture approach using NuGet packages. There are different NuGet packages for various features that can be added to the .NET Core project as needed.

> CLI Tools:
>* NET Core includes CLI tools (Command-line interface) for development and continuous-integration.

> Flexible Deployment:
>* .NET Core application can be deployed user-wide or system-wide or with Docker Containers

> Compatibility:
>* Compatible with .NET Framework and Mono APIs by using .NET Standard specification


# .NET Core Composition

* CLI Tools: A set of tooling for development and deployment.
* Roslyn: Language compiler for C# and Visual Basic
* CoreFX: Set of framework libraries.
* CoreCLR: A JIT based CLR (Command Language Runtime).

![Screenshot 2023-05-22 142134](https://github.com/a0s21en5/The-Complete-C-Sharp-Bootcamp/assets/86140629/23cf9fdd-42e8-43f4-b689-bf443d60af2b)

# ASP.NET Core
ASP.NET Core is the new version of the ASP.NET web framework mainly targeted to run on .NET Core platform.

# Why ASP.NET Core?

- **Supports Multiple Platforms**: ASP.NET Core applications can run on Windows, Linux, and Mac. So you don't need to build different apps for different platforms using different frameworks.

- **Fast**: ASP.NET Core no longer depends on System.Web.dll for browser-server communication. ASP.NET Core allows us to include packages that we need for our application. This reduces the request pipeline and improves performance and scalability.

- **IoC Container**: It includes the built-in IoC container for automatic dependency injection, which makes it maintainable and testable.

- **Integration with Modern UI Frameworks**: It allows you to use and manage modern UI frameworks such as AngularJS, ReactJS, Umber, Bootstrap, etc. using Bower (a package manager for the web).

- **Hosting**: ASP.NET Core web application can be hosted on multiple platforms with any web server such as IIS, Apache, etc. It is not dependent only on IIS as a standard .NET Framework.

- **Code Sharing**: It allows you to build a class library that can be used with other .NET frameworks such as .NET Framework 4.x or Mono. Thus a single code base can be shared across frameworks.

- **Side-by-Side App Versioning**: ASP.NET Core runs on .NET Core, which supports the simultaneous running of multiple versions of applications.

- **Smaller Deployment Footprint**: ASP.NET Core application runs on .NET Core, which is smaller than the full .NET Framework. So, the application which uses only a part of .NET CoreFX will have a smaller deployment size. This reduces the deployment footprint.

## .NET Core vs ASP.NET Core

**.NET Core:**

- Open-source and Cross-platform
- .NET Core is a runtime to execute applications built on it.
- Install .NET Core Runtime to run applications and install .NET Core SDK to build applications.
- [.NET Core GitHub Repository (Runtime)](https://github.com/dotnet/runtime)
- [.NET Core GitHub Repository (SDK)](https://github.com/dotnet/sdk)
- Latest version: .NET Core 3.1

**ASP.NET Core:**

- Open-source and Cross-platform
- ASP.NET Core is a web framework to build web apps, IoT apps, and mobile backends on top of .NET Core or .NET Framework.
- There is no separate runtime and SDK available for ASP.NET Core. The .NET Core runtime and SDK include ASP.NET Core libraries.
- [.NET Core GitHub Repository](https://github.com/dotnet/aspnetcore)
- Latest version: ASP.NET Core 3.1

Note: There is no separate versioning for ASP.NET Core. It aligns with the versions of .NET Core.

## Installing ASP.NET Core

1. Visit the official [ASP.NET Core website](https://dotnet.microsoft.com/).

2. Click on the "Download .NET" button located on the homepage.

3. On the download page, select the appropriate version of .NET Core SDK for your operating system and click on the download link.

4. Once the download is complete, run the installer to start the installation process.

5. Follow the instructions provided by the installer to complete the installation of .NET Core SDK, which includes ASP.NET Core libraries.

Note: Make sure to check for the latest version of ASP.NET Core on the official website and download the corresponding SDK for the best compatibility and features.

## Creating an ASP.NET Core Application

1. Open a terminal or command prompt.

2. Navigate to the directory where you want to create your ASP.NET Core application.

3. Run the following command to create a new ASP.NET Core project:

   ```shell
   dotnet new web -n MyAspNetCoreApp
   
4. Change into the project directory: 
   
   ```shell 
   cd MyAspNetCoreApp
   
5. Restore the project dependencies by running the following command: 
   
   ```shell
   dotnet restore
   
6. Build the application: 
   
   ```shell
   dotnet build
7. Run the application: 
   
   ```shell
   dotnet run
