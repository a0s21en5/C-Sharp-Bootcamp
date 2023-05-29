# Stored procedures in SQL
Stored Procedures are created to perform one or more DML operations on Database. It is nothing but the group of SQL statements that accepts some input in the form of parameters and performs some task and may or may not return a value. 

* Syntax:

> Creating a Procedure 
```
CREATE PROCEDURE procedure_name
(parameter1 data_type, parameter2 data_type, …)
AS
BEGIN
   — SQL statements to be executed
END
```

> To Execute the procedure
```
EXEC procedure_name parameter1_value, parameter2_value, ..
```

# Parameter Explanation
Parameters are used to pass values to the Procedure. There are different types of parameters, which are as follows: 

1. __BEGIN:__ This is what directly executes or we can say that it is an executable part.
2. __END:__ Up to this, the code will get executed.

# Example:
* Query:

```
-- Create a new database named "SampleDB"
CREATE DATABASE SampleDB;

-- Switch to the new database
USE SampleDB;

-- Create a new table named "Customers"
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(50),
    ContactName VARCHAR(50),
    Country VARCHAR(50)
);

-- Insert some sample data into the Customers table
INSERT INTO Customers (CustomerID, CustomerName, ContactName, Country)
VALUES (1, 'Shubham', 'Thakur', 'India'),
       (2, 'Aman ', 'Chopra', 'Australia'),
       (3, 'Naveen', 'Tulasi', 'Sri lanka'),
       (4, 'Aditya', 'Arpan', 'Austria'),
       (5, 'Nishant. Salchichas S.A.', 'Jain', 'Spain');

-- Create a stored procedure named "GetCustomersByCountry"
CREATE PROCEDURE GetCustomersByCountry
    @Country VARCHAR(50)
AS
BEGIN
    SELECT CustomerName, ContactName
    FROM Customers
    WHERE Country = @Country;
END;

-- Execute the stored procedure with parameter "Sri lanka"
EXEC GetCustomersByCountry @Country = 'Sri lanka';
```

# SQL Server stored procedure that includes all CRUD operations (Create, Read, Update, Delete):

```
-- Create stored procedure
CREATE PROCEDURE dbo.CRUDExample
(
    @ID INT = NULL,
    @Name NVARCHAR(50) = NULL,
    @Description NVARCHAR(MAX) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert data
    IF @ID IS NULL
    BEGIN
        INSERT INTO YourTableName (Name, Description)
        VALUES (@Name, @Description);
    END

    -- Update data
    ELSE
    BEGIN
        UPDATE YourTableName
        SET Name = @Name,
            Description = @Description
        WHERE ID = @ID;
    END

    -- Retrieve data
    SELECT ID, Name, Description
    FROM YourTableName
    WHERE ID = COALESCE(@ID, ID);

    -- Delete data
    IF @ID IS NOT NULL
    BEGIN
        DELETE FROM YourTableName
        WHERE ID = @ID;
    END
END
```

# To use this stored procedure, you can call it with the appropriate parameters.
```
# insert a new record:
EXEC dbo.CRUDExample
    @Name = 'Ashish',
    @Description = 'Example Description';


# To update an existing record:
EXEC dbo.CRUDExample
    @ID = 1, -- ID of the record to update
    @Name = 'Updated Name',
    @Description = 'Updated Description';


# To retrieve data:
EXEC dbo.CRUDExample
    @ID = 1; -- ID of the record to retrieve


# To delete a record: 
EXEC dbo.CRUDExample
    @ID = 1; -- ID of the record to delete
```