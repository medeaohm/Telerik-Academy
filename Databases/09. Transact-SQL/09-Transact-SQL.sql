--1.Create a database with two tables: `Persons(Id(PK), FirstName, LastName, SSN)` and `Accounts(Id(PK), PersonId(FK), Balance)`.
--		*	Insert few records for testing.
--		*	Write a stored procedure that selects the full names of all persons.

USE master
GO
-- Create a db named 'Accounts'
CREATE DATABASE Accounts
GO
USE Accounts
GO
--Create table Persons
CREATE TABLE Persons (
	PersonID int IDENTITY NOT NULL PRIMARY KEY,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	SSN nvarchar(50)
)
GO
--Create table Accounts
CREATE TABLE Accounts(
	AccountID int IDENTITY NOT NULL PRIMARY KEY,
	PersonId int NOT NULL FOREIGN KEY REFERENCES Persons(PersonID),
	Balance money
)
GO
--Insert few records for testing.
INSERT INTO Persons
	(FirstName,LastName,SSN)
VALUES 
	('Pesho','Peshev','12345678'),
	('Gosho','Goshev','87654321'),
	('Mariika','Marieva','54684665'),
	('Milenka','Milenova','00021133'),
	('Ivan','Ivanov','56874115'),
	('Gosho','Goshev','12345687'),
	('Genka','Genkova','98765432'),
	('Jena','Jenova','14785236')
GO
INSERT INTO Accounts 
	(PersonID,Balance)
VALUES 
	(1, 548.14),
	(2, 2253.52),
	(3, 455555.00),
	(4, 202020.75),
	(5, 68563.14),
	(6, 1000.52),
	(7, 524.00),
	(8, 5555.75)
GO
--Write a stored procedure that selects the full names of all persons.
CREATE PROCEDURE usp_SelectFullNames
	AS
		SELECT CONCAT(FirstName, ' ', LastName) AS FullName
		FROM Persons
GO
EXEC usp_SelectFullNames


DROP PROCEDURE usp_SelectAccountsWithBalanceGT;
GO

--2.Create a stored procedure that accepts a number as a parameter and returns all persons 
--  who have more money in their accounts than the supplied number.
CREATE PROCEDURE usp_SelectAccountsWithBalanceGT (@minbalance money = 1000)
	AS
		SELECT p.FirstName, p.LastName, a.Balance
		FROM Persons p
		JOIN Accounts a
			ON a.PersonId = p.PersonId
		WHERE a.Balance > @minbalance
GO
EXEC usp_SelectAccountsWithBalanceGT 2000

--3.Create a function that accepts as parameters – sum, yearly interest rate and number of months.
--		*	It should calculate and return the new sum.
--		*	Write a `SELECT` to test whether the function works as expected.
CREATE FUNCTION ufn_CalculateSumWithInterest (@sum MONEY, @yearInterest DECIMAL, @months INT) RETURNS MONEY
	AS
		BEGIN
			RETURN (@sum + @sum*(@yearInterest/100)*@months/12)
		END
GO
DECLARE @sum MONEY = (SELECT Balance FROM Accounts WHERE PersonId = 5)
PRINT dbo.ufn_CalculateSumWithInterest(@sum,2,5)

--4.Create a stored procedure that uses the function from the previous example to give 
--an interest to a person's account for one month.
--		*	It should take the `AccountId` and the interest rate as parameters.
CREATE PROCEDURE dbo.usp_CalculateInterestPerMonth(@accountId int, @yearlyInterestRate decimal)
AS
	DECLARE @balance money
	SELECT @balance = Balance FROM Accounts WHERE AccountID = @accountId
	
	DECLARE @newBalance money
	SELECT @newBalance = dbo.ufn_CalculateSumWithInterest(@balance,@yearlyInterestRate,1)
	
	SELECT p.FirstName, p.LastName, a.Balance, @newBalance AS [New Balance]
	FROM Persons p
	JOIN Accounts a
		ON p.PersonID = a.PersonId
	WHERE a.AccountID = @accountId
GO
EXEC dbo.usp_CalculateInterestPerMonth 5, 5.2

--5.Add two more stored procedures `WithdrawMoney(AccountId, money)` and `DepositMoney(AccountId, money)` 
--  that operate in transactions.
CREATE PROCEDURE dbo.usp_WithdrawMoney(@accountId int, @money money)
AS
    BEGIN TRAN
        UPDATE Accounts
        SET Balance -= @money
        WHERE AccountId = @accountId
    COMMIT TRAN
GO

CREATE PROCEDURE dbo.usp_DepositMoney(@accountId int, @money money)
AS
    BEGIN TRAN
        UPDATE Accounts
        SET Balance += @money
        WHERE AccountId = @accountId
    COMMIT TRAN
GO

EXEC dbo.usp_WithdrawMoney 8, 500

EXEC dbo.usp_DepositMoney 8, 500


--6.Create another table – `Logs(LogID, AccountID, OldSum, NewSum)`.
--		*	Add a trigger to the `Accounts` table that enters a new entry into the `Logs` table 
--			every time the sum on an account changes.
CREATE TABLE Logs(
	LogID int IDENTITY NOT NULL PRIMARY KEY,
	AccountID int NOT NULL FOREIGN KEY REFERENCES Accounts(AccountID),
	OldSum money,
	NewSum money
)

CREATE TRIGGER tr_UpdateAccountBalance ON Accounts FOR UPDATE
AS
    DECLARE @oldSum money;
    SELECT @oldSum = Balance FROM deleted;

    INSERT INTO Logs(AccountId, OldSum, NewSum)
        SELECT AccountId, @oldSum, Balance
        FROM inserted
GO

EXEC usp_WithdrawMoney 1, 1000
EXEC usp_WithdrawMoney 1, 1000
EXEC usp_DepositMoney 2, 2000

SELECT * FROM Logs


--7.Define a function in the database `TelerikAcademy` that returns all Employee's names (first or middle or last name) 
--  and all town's names that are comprised of given set of letters.
--		*	_Example_: '`oistmiahf`' will return '`Sofia`', '`Smith`', … but not '`Rob`' and '`Guy`'.
USE TelerikAcademy
GO

--DROP FUNCTION DBO.ufn_SearchForWordsInGivenPattern

CREATE FUNCTION ufn_SearchForPatternInNameOrTown(@pattern nvarchar(255))
	RETURNS @MatchedNames TABLE (Name varchar(50))
AS
BEGIN
	INSERT @MatchedNames
	SELECT * 
	FROM
		(SELECT e.FirstName FROM Employees e
        UNION
        SELECT e.LastName FROM Employees e
        UNION 
        SELECT t.Name FROM Towns t) as temp(name)
    WHERE PATINDEX('%[' + @pattern + ']', name) > 0
	RETURN
END
GO

SELECT * FROM ufn_SearchForPatternInNameOrTown('oistmiahf')
GO


--8.Using database cursor write a T-SQL script that scans all employees and their addresses and prints 
--  all pairs of employees that live in the same town.
DECLARE eCursor CURSOR READ_ONLY FOR
    SELECT e1.FirstName, e1.LastName, t1.Name, e2.FirstName, e2.LastName
    FROM Employees e1
    JOIN Addresses a1
        ON e1.AddressID = a1.AddressID
    JOIN Towns t1
        ON a1.TownID = t1.TownID,
        Employees e2
    JOIN Addresses a2
        ON e2.AddressID = a2.AddressID
    JOIN Towns t2
        ON a2.TownID = t2.TownID
    WHERE t1.TownID = t2.TownID AND e1.EmployeeID != e2.EmployeeID
    ORDER BY e1.FirstName, e2.FirstName

OPEN eCursor

DECLARE @firstName1 nvarchar(50), 
        @lastName1 nvarchar(50),
        @townName nvarchar(50),
        @firstName2 nvarchar(50),
        @lastName2 nvarchar(50)
FETCH NEXT FROM eCursor INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2

DECLARE @counter int;
SET @counter = 0;

WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @counter = @counter + 1;

		PRINT @firstName1 + ' ' + @lastName1 + 
			  '     ' + @townName + '       ' +
			  @firstName2 + ' ' + @lastName2;

		FETCH NEXT FROM eCursor 
		INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2
	END

print 'Total records: ' + CAST(@counter AS nvarchar(10));

CLOSE eCursor
DEALLOCATE eCursor