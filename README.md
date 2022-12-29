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

# Keywords

C# contains reserved words that have special meaning for the compiler. These reserved words are called "keywords". Keywords cannot be used as an identifier.

# Access Modifier

> **Public** : The Public modifier allows any part of the program in the same assembly or another assembly to access the type and its members.

> Private : The Private modifier restricts other parts of the program from accessing the type and its members. Only code in the same class or struct can access it.

> Internal : The Internal modifier allows other program code in the same assembly to access the type or its members. This is default access modifiers if no modifier is specified.

> Protected : The Protected modifier allows codes in the same class or a class that derives from that class to access the type or its members.

# Method Parameter
These keywords are applied to the parameters of a method.
- [x] ref
- [x] out
- [x] params

# Access
Access keywords are used to access the containing class or the base class of an object or class.
- [x] this
- [x] base