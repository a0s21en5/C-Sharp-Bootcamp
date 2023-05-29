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