
# C Sharp
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

# Let's understand the above C# structure.

>*Every .NET application takes the reference of the necessary .NET framework namespaces that it is planning to use with the using keyword, e.g., using System.Text.

>* Declare the namespace for the current class using the namespace keyword.

>* We declared a class using the class keyword: class Program

>* The Main() is a method of Program class is the entry point of the console application.

>* String is a data type.

>* A message is a variable that holds the value of a specified data type.

>* "Hello World!!" is the value of the message variable.

>*  The Console.WriteLine() is a static method, which is used to display a text on the console.

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

# Identifiers
All C# variables must be identified with unique names. These unique names are called identifiers.

> The general rules for naming variables are:
>* Names can contain letters, digits and the underscore character (_)
>* Names must begin with a letter
>* Names should start with a lowercase letter and it cannot contain whitespace
>* Names are case sensitive ("myVar" and "myvar" are different variables)
>* Reserved words (like C# keywords, such as int or double) cannot be used as names

# Keywords

C# contains reserved words that have special meaning for the compiler. These reserved words are called "keywords". Keywords cannot be used as an identifier.

# Access Modifier

> **Public** : The Public modifier allows any part of the program in the same assembly or another assembly to access the type and its members.

> **Private** : The Private modifier restricts other parts of the program from accessing the type and its members. Only code in the same class or struct can access it.

> **Internal** : The Internal modifier allows other program code in the same assembly to access the type or its members. This is default access modifiers if no modifier is specified.

> **Protected** : The Protected modifier allows codes in the same class or a class that derives from that class to access the type or its members.

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

# Namespace
Namespaces play an important role in managing related classes in C#. The .NET Framework uses namespaces to organize its built-in classes.

# Variables
Variables are containers for storing data values.
variables must be declared with the data type. These are called explicitly typed variables.
> type variableName = value;

# Implicitly Typed Variable
> var keyword to declare method level variables without specifying a data type explicitly.

> The compiler will infer the type of a variable from the expression on the right side of the = operator.

> Implicitly-typed variables must be initialized at the time of declaration; otherwise C# compiler would give an error: Implicitly-typed variables must be initialized.

# Data Types
It is a strongly-typed language. It means we must declare the type of a variable that indicates the kind of values it is going to store, such as integer, float, decimal, text, etc.
```
string stringVar = "Hello World!!";
int intVar = 100;
float floatVar = 10.2f;
char charVar = 'A';
bool boolVar = true;
```

# Type Casting
Type casting is when you assign a value of one data type to another type.

> In C#, there are two types of casting:

* Implicit Casting (automatically) - converting a smaller type to a larger type size ```char -> int -> long -> float -> double```

* Explicit Casting (manually) - converting a larger type to a smaller size type ```double -> float -> long -> int -> char```

> Type Conversion Methods
```
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
```

# Value Type and Reference Type
In C#, these data types are categorized based on how they store their value in the memory.

- [x] Value type
- [x] Reference type

* Value Type
> A data type is a value type if it holds a data value within its own memory space. It means the variables of these data types directly contain values.

For example, consider integer variable ```int i = 100;```

> The following data types are all of value type:
>* bool
>* byte
>* char
>* decimal
>* double
>* enum
>* float
>* int
>* long
>* sbyte
>* short
>* struct
>* uint
>* ulong
>* ushort

* Reference Type
> a reference type doesn't store its value directly. Instead, it stores the address where the value is being stored. In other words, a reference type contains a pointer to another memory location that holds the data.

For example, consider the following string variable:
```string s = "Hello World!!";```
> The followings are reference type data types:
>* String
>* Arrays (even if their elements are value types)
>* Class
>* Delegate

* Null
> The default value of a reference type variable is null when they are not initialized. Null means not refering to any object.

> A value type variable cannot be null because it holds value, not a memory address

* Nullable Types
> As you know, a value type cannot be assigned a null value. For example, int i = null will give you a compile time error. C# 2.0 introduced nullable types that allow you to assign null to value type variables. You can declare nullable types using Nullable<t> where T is a type.
```Nullable<int> i = null;```

# Interface
an interface can be defined using the interface keyword. An interface can contain declarations of methods, properties, indexers, and events. However, it cannot contain instance fields.

> Note:
>* An interface cannot contain constructors and fields.
>* Interface members are by default abstract and public.
>* Interface can contain declarations of method, properties, indexers, and events.
>* Interface cannot include private, protected, or internal members. All the members are public by default.
>* Interface cannot contain fields, and auto-implemented properties.
>* A class or a struct can implement one or more interfaces implicitly or explicitly. Use public modifier when implementing interface implicitly, whereas don't use it in case of explicit implementation.
>* Implement interface explicitly using InterfaceName.MemberName.
>* An interface can inherit one or more interfaces.

# Note:
>* Interface members must be implemented with the public modifier; otherwise, the compiler will give compile-time errors.
>* Do not use public modifier with an explicit implementation. It will give a compile-time error.

# Modifiers in Interfaces
allows private, protected, internal, public, virtual, abstract, sealed, static, extern, and partial modifiers in an interface.

# Ternary Operator
a decision-making operator ?: which is called the conditional operator or ternary operator. It is the short form of the if else conditions.
> Syntax:
>* ```condition ? statement 1 : statement 2```

# Switch Statement
> The switch statement can be used instead of if else statement when you want to test a variable against three or more conditions.
```
switch(match expression/variable)
{
    case constant-value:
        statement(s) to be executed;
        break;
    default: 
        statement(s) to be executed;
        break;
}
```

# Partial Classes
you can split the implementation of a class, a struct, a method, or an interface in multiple .cs files using the partial keyword. The compiler will combine all the implementation from multiple .cs files when the program is compiled.

> Rules for Partial Classes 
>* All the partial class definitions must be in the same assembly and namespace.
>* All the parts must have the same accessibility like public or private, etc.
>* If any part is declared abstract, sealed or base type then the whole class is declared of the same type.
>* Different parts can have different base types and so the final class will inherit all the base types.
>* The Partial modifier can only appear immediately before the keywords class, struct, or interface.
>* Nested partial types are allowed.

# Partial Methods
Partial classes or structs can contain a method that split into two separate .cs files of the partial class or struct. One of the two .cs files must contain a signature of the method, and other file can contain an optional implementation of the partial method. Both declaration and implementation of a method must have the partial keyword.

> Rules for Partial Methods
>* Partial methods must use the partial keyword and must return void.
>* Partial methods can have in or ref but not out parameters.
>* Partial methods are implicitly private methods, so cannot be virtual.
>* Partial methods can be static methods.
>* Partial methods can be generic.

> Static Class, Methods, Constructors, Fields
# Static Class
static means something which cannot be instantiated. You cannot create an object of a static class and cannot access static members using an object.

classes, variables, methods, properties, operators, events, and constructors can be defined as static using the static modifier keyword.

> Rules for Static Class
>* Static classes cannot be instantiated.
>* All the members of a static class must be static; otherwise the compiler will give an error.
>* A static class can contain static variables, static methods, static properties, static operators, static events, and static constructors.
>* A static class cannot contain instance members and constructors.
>* Indexers and destructors cannot be static
>* var cannot be used to define static members. You must specify a type of member explicitly after the static keyword.
>* Static classes are sealed class and therefore, cannot be inherited.
>* A static class cannot inherit from other classes.
>* Static class members can be accessed using ClassName.MemberName.
>* A static class remains in memory for the lifetime of the application domain in which your program resides.

# Static Methods
>Rules for Static Methods
>* Static methods can be defined using the static keyword before a return type and after an access modifier.
>* Static methods can be overloaded but cannot be overridden.
>* Static methods can contain local static variables.
>* Static methods cannot access or call non-static variables unless they are explicitly passed as parameters.

# Static Constructors
> Rules for Static Constructors
>* The static constructor is defined using the static keyword and without using access modifiers public, private, or protected.
>* A non-static class can contain one parameterless static constructor. Parameterized static constructors are not allowed.
>* Static constructor will be executed only once in the lifetime. So, you cannot determine when it will get called in an application if a class is being used at multiple places.
>* A static constructor can only access static members. It cannot contain or access instance members.

# Arrays
Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value. Array elements are stored contiguously in the memory.
```
Data_Type[] Array_Name;
string[] cars;
```
> an array can be of three types
>* Single-Dimensional Array
>* Multi-Dimensional Array
>* Jagged Array

> Array Declaration and Initialization
* An array can be declared using by specifying the type of its elements with square brackets.
```
int[] evenNums;
```
> The following declares and adds values into an array in a single statement.
```
int[] evenNums = new int[5]{ 2, 4, 6, 8, 10 }; 

string[] cities = new string[3]{ "Mumbai", "London", "New York" };
```
# Multidimensional Arrays
multidimensional arrays up to 32 dimensions. The multidimensional array can be declared by adding commas in the square brackets. For example, [,] declares two-dimensional array, [, ,], and so on. So, in a multidimensional array, no of commas = No of Dimensions - 1.
```
int[,] arr2d; // two-dimensional array
int[, ,] arr3d; // three-dimensional array
int[, , ,] arr4d ; // four-dimensional array
int[, , , ,] arr5d; // five-dimensional array
```

# Jagged Arrays: An Array of Array
A jagged array is an array of array. Jagged arrays store arrays instead of literal values.

A jagged array is initialized with two square brackets [][]. The first bracket specifies the size of an array, and the second bracket specifies the dimensions of the array which is going to be stored.
```
int[][] jArray1 = new int[2][]; // can include two single-dimensional arrays 
int[][,] jArray2 = new int[3][,]; // can include three two-dimensional arrays
```

# Indexers
# Generics
# Generic Constraints
# Generic & Non-generic Collections
# Tuple
# ValueTuple
# Built-in Exception
# Delegates
# Events
# Extension Method

Extension methods, as the name suggests, are additional methods. Extension methods allow you to inject additional methods without modifying, deriving or recompiling the original class, struct or interface.

> sealed class
>* it's mean locked 
>* in the sealed class we can not change anything
>* in the sealed class we can not create object
>* in the sealed class we can not create Inheritance

> Then we can use Extension Method

> a method you can write it by using a static keywords and you can extend the functionality of already existing class

> Extension Method needs to be defined in static

> static should have all its member as static

> First Parameter is binding Parameter

# Stream
# Working with Files & Directories
# FileInfo
# Object Initializer
# 

# MVC

Architecture design pattern to implement UI layer of Application.

MVC stands for Model, View, and Controller. MVC separates an application into three components - Model, View, and Controller.

> Model
>* .cs files ------ Properties
>* Model represents the data

> View
>* View in MVC is a user interface. 
>* .CSHTML
>* View is the User Interface.

> Controller
>* controller handles the user request.
>* Controller is the request handler.
