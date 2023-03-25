# LINQ (Language-Integrated Query)

> Language-Integrated Query (LINQ) is a powerful set of technologies based on the integration of query capabilities directly into the C# language.

> LINQ (Language Integrated Query) is uniform query syntax in C# to retrieve data from different sources and formats.

> It is integrated in C#

# Advantages of LINQ

> Familiar language: 
>* Developers don't have to learn a new query language for each type of data source or data format.

> Less coding: 
>* It reduces the amount of code to be written as compared with a more traditional approach.

> Readable code: 
>* LINQ makes the code more readable so other developers can easily understand and maintain it.

> Standardized way of querying multiple data sources: 
>* The same LINQ syntax can be used to query multiple data sources.

> Compile time safety of queries: 
>* It provides type checking of objects at compile time.

> IntelliSense Support: 
>* LINQ provides IntelliSense for generic collections.

> Shaping data: 
>* You can retrieve data in different shapes.

# LINQ Query Syntax

> There are two basic ways to write a LINQ query to IEnumerable collection or IQueryable data sources.
>* Query Syntax or Query Expression Syntax
>* Method Syntax or Method Extension Syntax or Fluent

> Query Syntax
>* Query syntax is similar to SQL (Structured Query Language) for the database. It is defined within the C#

>* LINQ Query Syntax:
```
from <range variable> in <IEnumerable<T> or IQueryable<T> Collection>

<Standard Query Operators> <lambda expression>

<select or groupBy operator> <result formation>
```