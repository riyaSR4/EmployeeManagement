--Create database
Create Database EmployeeManagement

Use EmployeeManagement;

--Create table
Create table Employee(
EmpId int primary key identity(1,1),
Name varchar(20),
City varchar(20),
Address varchar(30)
);

--Stored Procedure
Create procedure AddEmployee
(
@Name varchar(20),
@City varchar(20),
@Address varchar(30)
)
As
Begin
Insert into Employee(Name,City,Address) values(@Name,@City,@Address)
End

Create procedure GetAllEmployees
As
Begin
Select * from Employee
End

Create procedure DeleteEmployee
(
	@Id int
)
As
Begin
Delete from Employee where EmpId=@Id;
End

Create procedure UpdateEmployee
(
	@Id int,
	@Name varchar(20),
	@City varchar(20),
	@Address varchar(30)
)
As 
Begin
Update Employee set Name=@Name, City=@City, Address=@Address where EmpId=@Id
End

EXEC GetAllEmployees;



