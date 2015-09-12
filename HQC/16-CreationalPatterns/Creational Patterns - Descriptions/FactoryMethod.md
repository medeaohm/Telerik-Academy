##Builder Pattern##

In class-cased programming, the Factory Method Pattern is a **creational** pattern whitch uses factory methods to deal with the problem of creating object withoud specifying the exact class of object that will be created.

* **Motivation:**
The Factory Method pattern is used with an interface for the creation of different objects, but the concrete type of the object is chousen depending of the request of onother class. The created elements are refered by a mutual interface.

* **Intent and Applicability:**
Basically, the factory method design pattern is used when the class creating the objects cannot known a priori what kind of object should be created: only the class which have to make the request for the object creation is allowed to know the object type.to separate the construction of a complex object from its representation.

* **Known Uses:**
Example of the usage of the Factory Method pattern are:

	+ Toolkit
	+ Utility classes/frameworks
	+ MacApp
	+ ET++
	+ Unidraw

* **Implementation:**
The Factory Method pattern can be implementend basically in two different ways - by defining an abstact Creator class, which does not contain the implementation of the factory method itself or throught the definition of a concrete class, which implements the method.

	~~~c#
	using System;

namespace DoFactory.GangOfFour.Factory.Structural
{

	/// <summary>
	/// MainApp startup class for Structural 
	/// Factory Method Design Pattern.
	/// </summary>
  	class MainApp
	{

	/// <summary>
	/// Entry point into console application.
	/// </summary>
    	static void Main()
	{
	// An array of creators
	Creator[] creators = new Creator[2];
	creators[0] = new ConcreteCreatorA();
	creators[1] = new ConcreteCreatorB();

	// Iterate over creators and create products
	foreach (Creator creator in creators)
	{
		Product product = creator.FactoryMethod();
		Console.WriteLine("Created {0}",
		product.GetType().Name);
	}

	// Wait for user
	Console.ReadKey();
	}
}

	/// <summary>
	/// The 'Product' abstract class
	/// </summary>

	abstract class Product
	{
	}

	/// <summary>
	/// A 'ConcreteProduct' class
	/// </summary>
	class ConcreteProductA : Product
	{
	}

	/// <summary>
	/// A 'ConcreteProduct' class
	/// </summary>
	class ConcreteProductB : Product
	{
	}

	/// <summary>
	/// The 'Creator' abstract class
	/// </summary>

	abstract class Creator
	{
		public abstract Product FactoryMethod();
	}

 
	/// <summary>
	/// A 'ConcreteCreator' class
	/// </summary>
	class ConcreteCreatorA : Creator
	{
		public override Product FactoryMethod()
		{	
			return new ConcreteProductA();
		}
	}

 	/// <summary>
	/// A 'ConcreteCreator' class
	/// </summary>
	class ConcreteCreatorB : Creator
	{
		public override Product FactoryMethod()
		{
			return new ConcreteProductB();
		}
	}

}
~~~

* **Participants:**
The classes and objects participating in this pattern are:

	* Product  (Page): defines the interface of objects the factory method creates
	* ConcreteProduct  (SkillsPage, EducationPage, ExperiencePage): implements the Product interface
	* Creator  (Document): declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object or may call the factory method to create a Product object.
	* ConcreteCreator  (Report, Resume): overrides the factory method to return an instance of a ConcreteProduct.

* **Consequences:**
	* There is no nedd of connecting the application with concretes classes
	* The code uses only the Product interface and this results into the possibility to work with different ConcreteProduct classes 


* **Structure:**

![FactoryMethod](images/FactoryMethod.svg.png "Factory Method - UML diagram")