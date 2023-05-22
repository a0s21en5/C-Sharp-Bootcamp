# ASP.NET MVC 5.md

> ASP.NET is a free web framework for building websites and web applications on .NET Framework using HTML, CSS, and JavaScript. 

> ASP.NET MVC 5 is a web framework based on Model-View-Controller (MVC) architecture. 

> Developers can build dynamic web applications using ASP.NET MVC framework that enables a clean separation of concerns, fast development, and TDD friendly.

# MVC
MVC stands for Model, View, and Controller. MVC separates an application into three components - Model, View, and Controller.

> **Model**: Model represents the shape of the data. A class in C# is used to describe a model. Model objects store data retrieved from the database.
>* Model represents the data.

> **View**: View in MVC is a user interface. View display model data to the user and also enables them to modify them. View in ASP.NET MVC is HTML, CSS, and some special syntax (Razor syntax) that makes it easy to communicate with the model and the controller.
>* View is the User Interface.

> **Controller**: The controller handles the user request. Typically, the user uses the view and raises an HTTP request, which will be handled by the controller. The controller processes the request and returns the appropriate view as a response.
>* Controller is the request handler.

> The following figure illustrates the interaction between Model, View, and Controller.




![mvc-architecture](https://github.com/a0s21en5/The-Complete-C-Sharp-Bootcamp/assets/86140629/3cc1922a-a9dc-4d12-8d59-f3d51a9208bf)

# Points to Remember
* MVC stands for Model, View and Controller.
* Model represents the data
* View is the User Interface.
* Controller is the request handler.


# MVC Folder Structure
**Models:** The Models folder typically contains classes that represent the data and business logic of your application. These classes may correspond to database tables or other data sources.

**Views:** The Views folder contains the user interface components of your application. Each view corresponds to a specific action or page and is responsible for presenting data to the user.

**Controllers:** The Controllers folder contains classes that handle user requests, interact with models, and determine which views to render. Controllers contain action methods that respond to specific URLs or routes.

**Areas:** If your application has distinct functional areas, you can use the Areas folder to organize them. Each area can have its own subfolder structure with models, views, and controllers specific to that area.

**Scripts:** The Scripts folder typically contains client-side JavaScript files used in your application. These files can provide interactivity and enhance the user experience.

**Content:** The Content folder is used to store static files like CSS (Cascading Style Sheets), images, and other resources that are used to style and enhance the appearance of your application.

**App_Start:** The App_Start folder contains configuration files and code that are executed when your application starts up. This includes registering routes, filters, and other application-level settings.

**App_Data:** The App_Data folder is used to store data files that are not directly accessible to users, such as databases or other data stores.

**App_GlobalResources and App_LocalResources:** These folders are used for storing resource files that contain localized strings or other resources used in your application.

**Areas:** If you have divided your application into separate areas, each area can have its own set of folders (Models, Views, and Controllers) to organize the code specific to that area.

**Global.asax:** Global.asax file allows you to write code that runs in response to application-level events, such as Application_BeginRequest, application_start, application_error, session_start, session_end, etc.

**Packages.config:** Packages.config file is managed by NuGet to track what packages and versions you have installed in the application.

**Web.config:** Web.config file contains application-level configurations.

# Routing in MVC
* Routing plays important role in the MVC framework. Routing maps URL to physical file or class (controller class in MVC).
* Route contains URL pattern and handler information. URL pattern starts after the domain name.
* Routes can be configured in RouteConfig class. Multiple custom routes can also be configured.
* Route constraints apply restrictions on the value of parameters.
* Route must be registered in Application_Start event in Global.ascx.cs file.

# Controllers
* The Controller handles incoming URL requests. MVC routing sends requests to the appropriate controller and action method based on URL and configured Routes.
* All the public methods in the Controller class are called Action methods.
* The Controller class must be derived from System.Web.Mvc.Controller class.
* The Controller class name must end with "Controller".
* A new controller can be created using different scaffolding templates. You can create a custom scaffolding template also.

# Action method
* All the public methods in the Controller class are called Action methods.
* The Action method has the following restrictions.
    - Action method must be public. It cannot be private or protected.
    - Action method cannot be overloaded.
    - Action method cannot be a static method.
* ActionResult is a base class of all the result type which returns from Action method.
* The base Controller class contains methods that returns appropriate result type e.g. View(), Content(), File(), JavaScript() etc.
* The Action method can include Nullable type parameters.

![Action Method](https://github.com/a0s21en5/The-Complete-C-Sharp-Bootcamp/assets/86140629/1bd3ee23-32cb-4d4a-9ecd-416b7148971b)


# Action Selectors in MVC

In ASP.NET MVC (Model-View-Controller), action selectors are attributes that are applied to action methods in controllers to determine how the methods are selected and invoked in response to incoming requests. Action selectors help in routing requests to the appropriate action method based on various criteria.

Here are some commonly used action selectors in MVC:

1. **HttpGet**: The `[HttpGet]` attribute specifies that the action method should only be invoked for HTTP GET requests. This is the default HTTP verb for retrieving data.

2. **HttpPost**: The `[HttpPost]` attribute specifies that the action method should only be invoked for HTTP POST requests. This is typically used for submitting data or performing operations that modify data.

3. **HttpPut**: The `[HttpPut]` attribute specifies that the action method should only be invoked for HTTP PUT requests. PUT is often used for updating resources.

4. **HttpDelete**: The `[HttpDelete]` attribute specifies that the action method should only be invoked for HTTP DELETE requests. DELETE is used for deleting resources.

5. **AcceptVerbs**: The `[AcceptVerbs]` attribute allows you to specify multiple HTTP verbs for an action method. You can pass an array of HTTP verb strings as parameters to the attribute. For example, `[AcceptVerbs(HttpVerbs.Get, HttpVerbs.Post)]`.

6. **ActionName**: The `[ActionName]` attribute allows you to specify a different name for an action method than its actual method name. This can be useful when you want to have a more user-friendly or SEO-friendly URL.

7. **NonAction**: The `[NonAction]` attribute is applied to methods that should not be treated as action methods. These methods are typically utility methods or helper methods within a controller.

8. **AllowAnonymous**: The `[AllowAnonymous]` attribute allows anonymous access to an action method that is otherwise protected by authentication or authorization filters. It overrides any global or controller-level authorization rules.

9. **Route**: The `[Route]` attribute allows you to define custom routing patterns for an action method. It provides more flexibility in specifying the URL pattern for accessing the action method.
