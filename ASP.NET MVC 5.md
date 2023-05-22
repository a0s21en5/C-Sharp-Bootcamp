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
