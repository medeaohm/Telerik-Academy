## SQL Server and MySQL - Introduction
### _Homework_

1.	Download and install SQL Server Express. Install also SQL Server Management Studio Express (this could take some effort but be persistent).
2.	Connect to the SQL Server with SQL Server Management Studio
	*	Use Windows authentication.
3.	Create a new database `Pubs` and create new login with permissions to connect to it. Execute the script `install_pubs.sql` to populate the DB contents (you may need slightly to edit the script before).
4.	Attach the database `Northwind` (use the files `Northwind.mdf` and `Northwind.ldf`) to SQL Server and connect to it.
5.	Backup the database `Northwind` into a file named `northwind-backup.bak` and restore it as database named `North`.
6.	Export the entire `Northwind` database as SQL script
	*	Use `[Tasks]` > `[Generate Scripts]`
	*	Ensure you have exported table data rows (not only the schema).
7.	Create a database NW and execute the script in it to create the database and populate table data.
8.	Detatch the database NW and attach it on another computer in the training lab
	*	In case of name collision, preliminary rename the database.
9.	Download and install MySQL Community Server  + MySQL Workbench + the sample databases.
10.	Export the MySQL sample database "`world`" as SQL script.
11.	Modify the script and execute it to restore the database world as "`worldNew`".
12.	Connect through the MySQL console client and list the first 20 tons from the database "`worldNew`".

#### As a result of your homework provide screenshots
