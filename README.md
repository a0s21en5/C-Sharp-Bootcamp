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
# Class
class is a template or blueprint that defines by user in which we define the properties & behaviour of objects.
```
class Student
{
    
}
```
A class can contain one or more constructors, fields, methods, properties, delegates, and events. They are called class members. A class and its members can have access modifiers such as public, private, protected, and internal, to restrict access from other parts of the program.

# Field
A class can have one or more fields. It is a class-level variable that holds a value. Generally, field members should have a private access modifier used with property.

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

