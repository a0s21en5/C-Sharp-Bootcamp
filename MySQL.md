# MySQL

* MySQL is a widely used relational database management system (RDBMS).
* MySQL is free and open-source.
* MySQL is ideal for both small and large applications.
* MySQL is very fast, reliable, scalable, and easy to use
* MySQL is cross-platform
* MySQL is compliant with the ANSI SQL standard
* MySQL was first released in 1995
* MySQL is developed, distributed, and supported by Oracle Corporation.

# RDBMS

* RDBMS stands for Relational Database Management System.

* RDBMS is a program used to maintain a relational database.

* RDBMS uses SQL queries to access the data in the database.

# Database Table

* A table is a collection of related data entries, and it consists of columns and rows.

* A column holds specific information about every record in the table.

* A record (or row) is each individual entry that exists in a table.

# Relational Database

> A relational database defines database relationships in the form of tables. The tables are related to each other - based on data common to each.

# SQL

* SQL is the standard language for dealing with Relational Databases.

* SQL is used to insert, search, update, and delete database records.

# Note 

> SQL keywords are NOT case sensitive: select is the same as SELECT

> Some database systems require a semicolon at the end of each SQL statement.

# SELECT

The ```SELECT``` statement is used to select data from a database.
The data returned is stored in a result table, called the result-set.

```
SELECT * FROM table_name;
```

# SELECT DISTINCT

The SELECT DISTINCT statement is used to return only distinct (different) values.

```
SELECT DISTINCT column1 FROM table_name;
```

# WHERE Clause

The WHERE clause is used to filter records. It is used to extract only those records that fulfill a specified condition.

> Note:
>* The WHERE clause is not only used in SELECT statements, it is also used in UPDATE, DELETE, etc.!

# AND, OR and NOT Operators

> The WHERE clause can be combined with AND, OR, and NOT operators.

> The AND and OR operators are used to filter records based on more than one condition:
>* The AND operator displays a record if all the conditions separated by AND are TRUE.
>* The OR operator displays a record if any of the conditions separated by OR is TRUE.

> The NOT operator displays a record if the condition(s) is NOT TRUE.