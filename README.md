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

# Data Types
It is a strongly-typed language. It means we must declare the type of a variable that indicates the kind of values it is going to store, such as integer, float, decimal, text, etc.
```
string stringVar = "Hello World!!";
int intVar = 100;
float floatVar = 10.2f;
char charVar = 'A';
bool boolVar = true;
```

# Variables
Variables are containers for storing data values.

> type variableName = value;

# Identifiers
All C# variables must be identified with unique names. These unique names are called identifiers.

> The general rules for naming variables are:
>* Names can contain letters, digits and the underscore character (_)
>* Names must begin with a letter
>* Names should start with a lowercase letter and it cannot contain whitespace
>* Names are case sensitive ("myVar" and "myvar" are different variables)
>* Reserved words (like C# keywords, such as int or double) cannot be used as names

# Type Casting
Type casting is when you assign a value of one data type to another type.

> In C#, there are two types of casting:

* Implicit Casting (automatically) - converting a smaller type to a larger type size ```char -> int -> long -> float -> double```

* Explicit Casting (manually) - converting a larger type to a smaller size type ```double -> float -> long -> int -> char```