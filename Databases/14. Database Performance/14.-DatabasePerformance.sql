--01. Create a table in SQL Server with 10 000 000 log entries (date + text). Search in the table by date range. Check the speed (without caching).                               

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

-- Creating the table
CREATE TABLE Babies(
	Id int NOT NULL PRIMARY KEY IDENTITY,
	Name varchar(100),
	BDate date
)
GO
INSERT INTO Babies(Name, BDate) VALUES ('Pepinka', GETDATE())
INSERT INTO Babies(Name, BDate) VALUES ('Miminka', GETDATE() + 1)
INSERT INTO Babies(Name, BDate) VALUES ('Gohko', GETDATE() + 2)
INSERT INTO Babies(Name, BDate) VALUES ('Ivan4o', GETDATE() + 3)
INSERT INTO Babies(Name, BDate) VALUES ('Ki4ka', GETDATE() + 4)
INSERT INTO Babies(Name, BDate) VALUES ('Rali', GETDATE() + 5)
INSERT INTO Babies(Name, BDate) VALUES ('Mitko', GETDATE() + 6)
INSERT INTO Babies(Name, BDate) VALUES ('Luna', GETDATE() + 7)
INSERT INTO Babies(Name, BDate) VALUES ('Ginka', GETDATE() + 8)
INSERT INTO Babies(Name, BDate) VALUES ('Suhar4o', GETDATE() + 9)
GO

DECLARE @Counter int = 0
WHILE (SELECT COUNT(*) FROM Babies) < 10000000
BEGIN
	INSERT INTO Babies(Name, BDate)
	SELECT Name + CONVERT(varchar, @Counter), GETDATE() + @Counter FROM Babies
	SET @Counter = @Counter + 1
END
GO
-- Elapsed Time: 00:03:21 (creating the table)

SELECT * FROM Babies
WHERE BDate BETWEEN GETDATE() AND GETDATE() + 15
-- Elapset Time: 00:00:18


-----------------------------------------------------------------------------------------
-- 02. Add an index to speed-up the search by date. Test the search speed (after cleaning the cache).                               
CREATE INDEX IDX_Trainers_PostDate
ON Babies(BDate)

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Babies
WHERE BDate BETWEEN GETDATE() AND GETDATE() + 15

-- Elapsed Time: 00:00:17


-----------------------------------------------------------------------------------------
-- 03. Add a full text index for the text column. Try to search with and without the full-text index and compare the speed.                              

CREATE FULLTEXT CATALOG BabiesNameFullTextCatalog
WITH ACCENT_SENSITIVITY = OFF

CREATE FULLTEXT INDEX ON Babies(Name)
KEY INDEX PK__Babies__366A1A7C3E923D38
ON Babies
WITH CHANGE_TRACKING AUTO

-- Searching without full-text index
CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache
SELECT * FROM Babies
WHERE Name LIKE 'Ki4ka%'
GO

-- Elapsed Time: 00:00:07


--------------------------------------------------------------------------------------------------------------------------------------
-- TASK 04: Create the same table in MySQL and partition it by date (1990, 2000, 2010). Fill 1 000 000 log entries. Compare the searching speed in 
-- all partitions (random dates) to certain partition (e.g. year 1995).                           

-- Without partitioning
CREATE SCHEMA `babies`;

CREATE TABLE `babies`.`logs` (
	`Id` INT NOT NULL AUTO_INCREMENT,
	`Name` TEXT NOT NULL,
	`BDate` DATETIME NOT NULL,
	PRIMARY KEY (`Id`));

-- With partitioning
CREATE SCHEMA `babies`;

CREATE TABLE `babies`.`logs` (
	`Id` INT NOT NULL AUTO_INCREMENT,
	`Name` TEXT NOT NULL,
	`BDate` DATETIME NOT NULL,
	PRIMARY KEY (`Id`, `BDate`)
) PARTITION BY RANGE(YEAR(BDate)) (
    PARTITION p0 VALUES LESS THAN (1990),
    PARTITION p1 VALUES LESS THAN (2000),
    PARTITION p2 VALUES LESS THAN (2010),
    PARTITION p3 VALUES LESS THAN MAXVALUE
);

-- EXPLAIN PARTITIONS SELECT * FROM Logs;