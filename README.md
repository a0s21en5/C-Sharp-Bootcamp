# C#
- [x] It is an object-oriented programming language created by Microsoft that runs on the .NET Framework.
- [x] C# is used to develop web apps, desktop apps, mobile apps, games and much more.
- [x] C# is pronounced "C-Sharp".

> C# is used for:
>* Mobile applications
>* Desktop applications
>* Web applications
>* Web services
>* Web sites
>* Games
>* VR
>* Database applications

# Syntax

```
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");    
    }
  }
}
```

# Example explained

- Line 1: **using System** means that we can use classes from the System namespace.
- **Line 2:** A blank line. C# ignores white space.

- **Line 3:** namespace is used to organize your code, and it is a container for classes and other namespaces.

- **Line 4:** The curly braces {} marks the beginning and the end of a block of code.

- **Line 5:** class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.

- **Line 7:** Another thing that always appear in a C# program, is the Main method. Any code inside its curly brackets {} will be executed. You don't have to understand the keywords before and after Main. You will get to know them bit by bit while reading this tutorial.

- **Line 9:** Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text. In our example it will output "Hello World!".

If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.

> **Note:** Every C# statement ends with a semicolon ;.

> **Note:** C# is case-sensitive: "MyClass" and "myclass" has different meaning.


# OOp

# Class
class is a template or blueprint that defines by user in which we define the properties & behaviour of objects.

# Object 
object is a instance of a class that represent the class and an object is an real entity that has state and behaviour.

# Constructor
constructor is a special type of method whoose name is same as class name, it is invoked automatically at the time of object creation.

# Note
The main purpose of constructor is used to initialize the data member of new object.

# Types of Constructor
- [x] Default Constructor
- [x] Parameter Constructor

# Properties and Encapsulation
The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:

[x] declare fields/variables as private
[x] provide public get and set methods, through properties, to access and update the value of a private field

# Properties

You learned from the previous chapter that private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.

A property is like a combination of a variable and a method, and it has two methods: a get and a set method:

# Inheritance (Derived and Base Class)

In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:

[x] Derived Class (child) - the class that inherits from another class
[x] Base Class (parent) - the class being inherited from

To inherit from a class, use the : symbol.

# Abstract Classes and Methods

Data abstraction is the process of hiding certain details and showing only essential information to the user.
Abstraction can be achieved with either abstract classes or interfaces

The abstract keyword is used for classes and methods:

[x] Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

[x] Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
