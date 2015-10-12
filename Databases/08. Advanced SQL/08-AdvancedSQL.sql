--0.Start SQL Management Studio and connect to the database TelerikAcademy. Examine the major tables in the 
--"TelerikAcademy" database.
-- -> Execute the script Create-TelerikAcademy-Database-SQL-Script.sql

USE [TelerikAcademy];

--1.Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
SELECT FirstName, LastName, Salary FROM [dbo].[Employees]
WHERE Salary = 
	(SELECT MIN(Salary) FROM [dbo].[Employees]);

--2.Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% 
--	higher than the minimal salary for the company.
SELECT FirstName, LastName, Salary FROM [dbo].[Employees]
WHERE Salary BETWEEN 
	(SELECT (MIN(Salary) * 1) FROM [dbo].[Employees]) AND (SELECT (MIN(Salary) * 1.1) FROM [dbo].[Employees]);

--3.Write a SQL query to find the full name, salary and department of the employees that take 
--	the minimal salary in their department.
SELECT FirstName, LastName, DepartmentID, Salary
FROM Employees e
WHERE Salary = 
  (SELECT Min(Salary) FROM Employees 
   WHERE DepartmentID = e.DepartmentID)
ORDER BY DepartmentID;

--4.Write a SQL query to find the average salary in the department #1.
SELECT  AVG(Salary) [Average Salary] FROM Employees 
WHERE DepartmentID = 1;

--5.Write a SQL query to find the average salary  in the "Sales" department.
SELECT  AVG(Salary) [Average Salary]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
			WHERE d.Name = 'Sales';

--6.Write a SQL query to find the number of employees in the "Sales" department.
SELECT  Count(EmployeeID) [Number of employees]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
			WHERE d.Name = 'Sales';

--7.Write a SQL query to find the number of all employees that have manager.
SELECT  Count(EmployeeID) [Number of employees]
FROM Employees
	WHERE ManagerID IS NOT NULL;

--8.Write a SQL query to find the number of all employees that have no manager.
SELECT  Count(EmployeeID) [Number of employees]
FROM Employees
	WHERE ManagerID IS NULL;

--9.Write a SQL query to find all departments and the average salary for each of them.
SELECT DepartmentID, AVG(Salary) AS AverageSalary
FROM Employees
	GROUP BY DepartmentID;

--10.Write a SQL query to find the count of all employees in each department and for each town.
SELECT COUNT(EmployeeID) AS NumberOfEmployees, DepartmentID, AddressID 
FROM Employees
	GROUP BY DepartmentID, AddressID
		ORDER BY DepartmentID;

--11.Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT m.firstName, m.LastName FROM Employees m
	JOIN Employees e ON e.ManagerID = m.EmployeeID
		GROUP BY m.FirstName, m.LastName
		HAVING COUNT(e.ManagerID) = 5

--12.Write a SQL query to find all employees along with their managers. 
--	 For employees that do not have manager display the value "(no manager)".
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS [Employee Name],
	   COALESCE(emp.FirstName + ' '+ emp.LastName, 'no manager') AS [Manager Name]
	FROM Employees e
	LEFT JOIN Employees emp
		ON e.ManagerID = emp.EmployeeID

--13.Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. 
--	 Use the built-in `LEN(str)` function.
SELECT LastName FROM Employees
WHERE LEN(LastName) = 5;


--14.Write a SQL query to display the current date and time in the following format 
--	 "`day.month.year hour:minutes:seconds:milliseconds`".
SELECT FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss:fff');

--15. Write a SQL statement to create a table `Users`. Users should have username, password, full name and last login time.
--		*	Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
--		*	Define the primary key column as identity to facilitate inserting records.
--		*	Define unique constraint to avoid repeating usernames.
--		*	Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE Users (
	UserID int IDENTITY,
	Username nvarchar(20) NOT NULL,
	UserPassword nvarchar(30) NOT NULL,
	FullName nvarchar(200),
    LastLoginTime DATETIME,
    CONSTRAINT PK_Users PRIMARY KEY(UserID),
    CONSTRAINT UQ_Username UNIQUE(Username),
	)

--16. Write a SQL statement to create a view that displays the users from the `Users` table that have been in the system today.
CREATE VIEW [Users in system today] AS
SELECT Username FROM Users as u
WHERE DATEDIFF(day, LastLoginTime, GETDATE()) = 0

--17.Write a SQL statement to create a table `Groups`. Groups should have unique name (use unique constraint).
--  	*	Define primary key and identity column.
CREATE TABLE Groups (
	GroupID int IDENTITY,
	GroupName nvarchar(100) NOT NULL,
    CONSTRAINT PK_Groups PRIMARY KEY(GroupID),
    CONSTRAINT UQ_GroupName UNIQUE(GroupName),
	)

--18.Write a SQL statement to add a column `GroupID` to the table `Users`.
--		*	Fill some data in this new column and as well in the `Groups table.
--		*	Write a SQL statement to add a foreign key constraint between tables `Users` and `Groups` tables.
ALTER TABLE Users ADD GroupId int
GO

ALTER TABLE Users
    ADD CONSTRAINT FK_Users_Groups
    FOREIGN KEY (GroupId)
    REFERENCES Groups(GroupId)
GO

--19. Write SQL statements to insert several records in the `Users` and `Groups` tables.
INSERT INTO Groups VALUES
    ('Telerik Academy'),
    ('Facebook'),
    ('LinkedIn'),
    ('Gmail')


INSERT INTO Users VALUES
    ('user1', '111', 'name1', '2015-10-05 00:00:00', 1),
    ('user2', '112', 'name2', '2015-10-06 00:00:00', 1),
    ('user3', '113', 'name3', '2015-10-07 00:00:00', 3),
    ('user4', '114', 'name4', '2015-10-08 00:00:00', 4),
    ('user5', '115', 'name5', '2015-10-09 00:00:00', 4),
    ('user6', '116', 'name6', '2015-10-10 00:00:00', 3)

--20.Write SQL statements to update some of the records in the `Users` and `Groups` tables.
UPDATE Users
	SET Username = REPLACE(Username, 'user1', 'user1_replaced')
	WHERE GroupID % 2 = 1

--21.Write SQL statements to delete some of the records from the `Users` and `Groups` tables.
DELETE FROM Users
    WHERE UserID = 2

DELETE FROM Groups
    WHERE GroupName = 'Facebook'

--22.Write SQL statements to insert in the `Users` table the names of all employees from the `Employees` table.
--		*	Combine the first and last names as a full name.
--		*	For username use the first letter of the first name + the last name (in lowercase).
--		*	Use the same for the password, and `NULL` for last login time.
ALTER TABLE Users
DROP CONSTRAINT UQ_Username

INSERT INTO Users (Username, FullName, UserPassword, LastLoginTime)
        (SELECT LOWER(CONCAT(SUBSTRING(FirstName,1,1), LastName)),
                CONCAT(FirstName, ' ', LastName),
                LOWER(CONCAT(SUBSTRING(FirstName,1,1), LastName)),
				NULL
        FROM Employees)
GO

--23.Write a SQL statement that changes the password to `NULL` for all users that have not been in the system since 10.03.2010.
INSERT INTO Users VALUES
    ('user17', '111', 'name1', '2010-03-07 00:00:00', 1),
    ('user28', '112', 'name2', '2010-03-08 00:00:00', 1),
    ('user35', '113', 'name3', '2010-03-09 00:00:00', 3)
--sorry, the password does not allow null
 UPDATE Users
 SET UserPassword = '0'
 WHERE DATEDIFF(day, LastLoginTime, '2010-3-10') > 0

--24.Write a SQL statement that deletes all users without passwords (`NULL` password).
DELETE FROM Users
    WHERE UserPassword = '0'

--25.Write a SQL query to display the average employee salary by department and job title.
SELECT DepartmentID, JobTitle, AVG(Salary) AS [AverageSalary] FROM Employees
	GROUP BY DepartmentID, JobTitle
	ORDER BY DepartmentID

--26.Write a SQL query to display the minimal employee salary by department and job title 
--	 along with the name of some of the employees that take it.
SELECT MIN(e.Salary) AS [MinSalary], d.Name, e.JobTitle, MAX(CONCAT(e.FirstName, ' ', e.LastName)) AS [SomeEmployee]
FROM Employees e 
JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
		GROUP BY d.Name, e.JobTitle
		ORDER BY d.Name

--27.Write a SQL query to display the town where maximal number of employees work.
SELECT TOP 1 COUNT(e.EmployeeID) AS [MaxEmployees], t.Name 
FROM Employees e
JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
		ON t.TownID = a.TownID
			GROUP BY t.Name
			ORDER BY MaxEmployees DESC

--28.Write a SQL query to display the number of managers from each town.
SELECT COUNT(DISTINCT e.ManagerID) AS [NumberOfManagers], t.Name 
FROM Employees e
JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
		ON t.TownID = a.TownID
			GROUP BY t.Name
			ORDER BY [NumberOfManagers] DESC

--29.Write a SQL to create table `WorkHours` to store work reports for each employee (employee id, date, task, hours, comments).
--		*	Don't forget to define  identity, primary key and appropriate foreign key. 
--		*	Issue few SQL statements to insert, update and delete of some data in the table.
--		*	Define a table `WorkHoursLogs` to track all changes in the `WorkHours` table with triggers.
--		*	For each change keep the old record data, the new record data and the command (insert / update / delete).

--- TABLE: WorkHours
CREATE TABLE WorkHours (
    WorkReportId int IDENTITY,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    WorkingHours Int NOT NULL,
    Comments nvarchar(256),
    CONSTRAINT PK_Id PRIMARY KEY(WorkReportId),
    CONSTRAINT FK_Employees_WorkHours 
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId)
) 
GO

--- INSERT
DECLARE @counter int;
SET @counter = 20;
WHILE @counter > 0
BEGIN
    INSERT INTO WorkHours(EmployeeId, OnDate, Task, WorkingHours)
    VALUES (@counter, GETDATE(), 'TASK: ' + CONVERT(varchar(10), @counter), @counter)
    SET @counter = @counter - 1
END

--- UPDATE
UPDATE WorkHours
SET Comments = 'It is enought'
WHERE WorkingHours > 12

--- DELETE
DELETE FROM WorkHours
WHERE EmployeeId IN (1, 3, 5, 7, 13)

--- TABLE: WorkHoursLogs
CREATE TABLE WorkHoursLogs (
    WorkLogId int,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    WorkingHours Int NOT NULL,
    Comments nvarchar(256),
    [Action] nvarchar(50) NOT NULL,
    CONSTRAINT FK_Employees_WorkHoursLogs
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId),
    CONSTRAINT [CC_WorkReportsLogs] CHECK ([Action] IN ('Insert', 'Delete', 'DeleteUpdate', 'InsertUpdate'))
) 
GO

--- TRIGGER FOR INSERT
CREATE TRIGGER tr_InsertWorkReports ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, WorkingHours, Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, WorkingHours, Comments, 'Insert'
    FROM inserted
GO

--- TRIGGER FOR DELETE
CREATE TRIGGER tr_DeleteWorkReports ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, WorkingHours, Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, WorkingHours, Comments, 'Delete'
    FROM deleted
GO

--- TRIGGER FOR UPDATE
CREATE TRIGGER tr_UpdateWorkReports ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, WorkingHours, Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, WorkingHours, Comments, 'InsertUpdate'
    FROM inserted

INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, WorkingHours, Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, WorkingHours, Comments, 'DeleteUpdate'
    FROM deleted
GO

--- TEST TRIGGERS
DELETE FROM WorkHoursLogs

INSERT INTO WorkHours(EmployeeId, OnDate, Task, WorkingHours)
VALUES (25, GETDATE(), 'TASK: 25', 25)

DELETE FROM WorkHours
WHERE EmployeeId = 25

UPDATE WorkHours
SET Comments = 'Updated'
WHERE EmployeeId = 2


--30.Start a database transaction, delete all employees from the '`Sales`' department along with all dependent records from the pother tables.
--		*	At the end rollback the transaction.
BEGIN TRANSACTION
    ALTER TABLE Departments
        DROP CONSTRAINT FK_Departments_Employees
    GO
	DELETE e FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'
ROLLBACK TRANSACTION

--31.Start a database transaction and drop the table `EmployeesProjects`.
--		*	Now how you could restore back the lost table data?
BEGIN TRANSACTION
	DROP TABLE EmployeesProjects
ROLLBACK TRANSACTION

--32.Find how to use temporary tables in SQL Server.
--		*	Using temporary tables backup all records from `EmployeesProjects` and restore them back after dropping and 
--			re-creating the table.
BEGIN TRANSACTION

SELECT * INTO #TempEmployeesProjects  --- Create new table
FROM EmployeesProjects

DROP TABLE EmployeesProjects

SELECT * INTO EmployeesProjects --- Create new table
FROM #TempEmployeesProjects;

DROP TABLE #TempEmployeesProjects

ROLLBACK TRANSACTION
--- COMMIT TRANSACTION