# Object Oriented Programming

Object-oriented programming is a way of developing software applications using real-world terminologies to create entities that interact with one another using objects.

Object-oriented programming makes applications flexible (easy to change or add new features), reusable, well-structured, and easy to debug and test.

# the following basic building blocks to build object-oriented applications:

> Classes
>* A Class define the structure using methods and properties/fields that resemble real-world entity.

> Methods
>* A method represents a particular behavior. It performs some action and might return information about an object, or update an object’s data.

> Properties
>* Properties hold the data temporarily during the execution of an application.

> Objects
>* Objects are instances of the class that holds different data in properties/fields and can interact with other objects.

> Interfaces
>* An interface is a contract that defines the set of rules for a particular functionality. They are used effectively with classes using OOP principles like inheritance and polymorphism to make applications more flexible.

# Object-oriented Design Principles

There are various object-oriented principles and techniques using which you can develop applications that are maintainable and extendable.

> The followings are four main principles of object-oriented programming:

>* Abstraction
>* Encapsulation
>* Inheritance
>* Polymorphism

# Steps for Developing Object-oriented Applications

Developing an object-oriented application starts with the business requirement document.

> Abstraction
>* First, identify essential entities and their characteristic from the business requirement for a high-level view.

> Encapsulation
>* An implementation of abstraction in code. Create classes and their members with appropriate access modifiers to show functionalities and hide details and complexity.

> Define relationship
>* Establish relationships between classes using inheritance and polymorphism.

> Use Principles & Patterns
>* Use the SOLID principles and Design Patterns as and when necessary to make applications flexible.

# Class
class is a template or blueprint that defines by user in which we define the properties & behaviour of objects.
```
class Student
{
    
}
```
A class can contain one or more constructors, fields, methods, properties, delegates, and events. They are called class members. A class and its members can have access modifiers such as public, private, protected, and internal, to restrict access from other parts of the program.

# Property
A property encapsulates a private field using setter and getter to assign and retrieve underlying field value.
```
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
```

# Field
A class can have one or more fields. It is a class-level variable that holds a value. Generally, field members should have a private access modifier used with property.
```
class Student
{
    public int id;

}
```

# Object 
object is a instance of a class that represent the class and an object is an real entity that has state and behaviour.
You can create one or more objects of a class. Each object can have different values of properties and field but methods and events behaves the same.
```
Student myobj = new Student();
```

# Methods
A method is a block of code which only runs when it is called. You can pass data, known as parameters, into a method. Why use methods? To reuse code: define the code once, and use it many times.

A method can contain one or more statements to be executed as a single unit. A method may or may not return a value. A method can have one or more input parameters.
```
[access-modifier] return-type MethodName(type parameterName1, type parameterName2,...)
{
    

}
```
> Two Type of Methods
>* Static Method :- Using Class to call a Method
>* Non-Static Method or Instance Method :- Using Object to call a Method

> According to Parameters there are Two Type of Methods
>* Parameterized Methods
>* Non-Parameterized Methods

> Method Overloading
With method overloading, multiple methods can have the same name with different parameters.
```
int MyMethod(int x)
float MyMethod(float x)
double MyMethod(double x, double y)
```

# Method Parameter
These keywords are applied to the parameters of a method.
- [x] ref
- [x] out
- [x] params

# Constructor
A constructor is a special type of method which will be called automatically when you create an instance of a class. A constructor is defined by using an access modifier and class name
```
<access-modifier> <class-name>(){ }
```
- [x] A constructor name must be the same as a class name.
- [x] A constructor can be public, private, or protected.
- [x] The constructor cannot return any value so cannot have a return type.
- [x] A class can have multiple constructors with different parameters but can only have one parameterless constructor.
- [x] If no constructor is defined, the C# compiler would create it internally.

# Abstraction

Abstraction is a higher-level concept or a way of thinking when you start designing your application from the business requirement.
Data abstraction is the process of hiding certain details and showing only essential information to the user.
Abstraction can be achieved with either abstract classes or interfaces

> The abstract keyword is used for classes and methods:
>* ```Abstract class:``` is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
>* ```Abstract method:``` can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
