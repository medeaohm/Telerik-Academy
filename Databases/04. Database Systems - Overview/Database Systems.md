##Database Systems##

* **What database models do you know?**
	+ Hierarchical (tree)
	+ Network / graph
	+ Relational (table)
	+ Object-oriented

* **Which are the main functions performed by a Relational Database Management System (RDBMS)?**
	+ Relational Database Management Systems (RDBMS) manage data stored in tables
	+ RDBMS systems typically implement
		+ Creating / altering / deleting tables and relationships between them (database schema)
		+ Adding, changing, deleting, searching and retrieving of data stored in the tables
		+ Support for the SQL language
		+ Transaction management (optional)

* **Define what is "table" in database terms.**
Database tables consist of data, arranged in rows and columns
For example (table Persons):

	| ID | Firstname | Lastname |  Employer  |
	|----|-----------|----------|------------|
	|  1 |  Steve    |  Jobs    |  Apple     | 
	|  2 |  Bill     |  Gates   |  Microsoft | 
	|  3 |  Jeff     |  Bezos   |  Amazon    | 

	+ All rows have the same structure
	+ Columns have name and type (number, string, date, image, or other)

* **Explain the difference between a primary and a foreign key.**
	+ Primary key is a column of the table that uniquely identifies its rows (usually its is a number). Basically, two records (rows) are different if and only if their primary keys are different. The primary key can be also composed by several columns (composite primary key)
	+ Relationships between tables are based on interconnections: primary key / foreign key
	+ The foreign key is an identifier of a record located in another table (usually its primary key). By using relationships we avoid repeating data in the database

* **Explain the different kinds of relationships between tables in relational databases.**
Relationships have multiplicity: 
	+ Relationship one-to-many (or many-to-one)
		+ A single record in the first table has many corresponding records in the second table
		+ Used very often
	+ Relationship many-to-many
		+ Records in the first table have many correspon-ding records in the second one and vice versa
		+ Implemented through additional table
	+ Relationship one-to-one
		+ A single record in a table corresponds to a single record in the other table
		+ Used to model inheritance between tables

* **When is a certain database schema normalized?**
Normalization of the relational schema removes repeating data, so a certain database schema is normalized when it does not contain duplicated data.

* **What are the advantages of normalized databases?**
The benefits of normalization include:
	+ Searching, sorting, and creating indexes is faster, since tables are narrower, and more rows fit on a data page.
	+ You usually have more tables.
	+ You can have more clustered indexes (one per table), so you get more flexibility in tuning queries.
	+ Index searching is often faster, since indexes tend to be narrower and shorter.
	+ More tables allow better use of segments to control physical placement of data.
	+ You usually have fewer indexes per table, so data modification commands are faster.
	+ Fewer null values and less redundant data, making your database more compact.
	+ Triggers execute more quickly if you are not maintaining redundant data.
	+ Data modification anomalies are reduced.
	+ Normalization is conceptually cleaner and easier to maintain and change as your needs change.
	
* **What are database integrity constraints and when are they used?**
Integrity constraints ensure data integrity in the database tables. They are used to enforce data rules which cannot be violated. The integrity constrains are:
	+ Foreign key constraint
		+ Ensures that the value in given column is a key from another table
	+ Check constraint
		+ Ensures that values in a certain column meet some predefined condition

* **Point out the pros and cons of using indexes in a database.**
Indexes in a database are usually implemented as B-trees. Also, indices can be built-in the table (clustered) or stored externally (non-clustered). In general, indices should be used for big tables only
	 + Pros:
		 + Indices speed up searching of values in a certain column or group of columns
	 + Cons:
		 + Adding and deleting records in indexed tables is slower!

* **What's the main purpose of the SQL language?**
SQL (Structured Query Language) is a standardized declarative language for manipulation of relational databases. Currently, SQL-99 is in use in most databases. The SQL language supports:
	+ Creating, altering, deleting tables and other objects in the database
	+ Searching, retrieving, inserting, modifying and deleting table data (rows)

* **What are transactions used for? Give an example.**
Transactions are a sequence of database operations which are executed as a single unit:
	+ Either all of them execute successfully
	+ Or none of them is executed at all
	+ Example:
		+ A bank transfer from one account into another (withdrawal + deposit). If either the withdrawal or the deposit fails the entire operation should be cancelled

* **What is a NoSQL database?**
	+ NoSQL (non-relational) databases:
		+ Use document-based model (non-relational)
		+ Schema-free document storage
			+ Still support CRUD operations
				+ Create, Read, Update, Delete
			+ Still support indexing and querying
			+ Still supports concurrency and transactions
	+ Highly optimized for append / retrieve
	+ Great performance and scalability
	+ NoSQL == “No SQL” or “Not Only SQL”?

* **Explain the classical non-relational data models.**
	+ Document model (e.g. MongoDB, CouchDB
		+ Set of documents, e.g. JSON strings
	+ Key-value model (e.g. Redis)
		+ Set of key-value pairs
	+ Hierarchical key-value
		+ Hierarchy of key-value pairs
	+ Wide-column model (e.g. Cassandra)
		+ Key-value model with schema
	+ Object model (e.g. Cache)
		+ Set of OOP-style objects

* **Give few examples of NoSQL databases and their pros and cons.**
    + Databases:
	    +  Cassandra (Distributed wide-column database)
	    + MongoDB (Mature and powerful JSON-Document database)
	    + CouchDB (JSON-based document database with REST API)
	    + Redis (Ultra-fast in-memory data structures server)
	    + H-Base
    + Models: 
	    + Document model
	    + Associative (Key-value) model
	    + Hierarchical key-value model
	    + Wide-column model
	    + Object model
    + Pros: 
	    + Support CRUD operations
	    + Support Indexing and querying
	    + Support concurrency and transactions
	    + Highly optimized for append / retrieve
	    + Great performance and scalability
    + Cons:
	   + Difficult administration and support