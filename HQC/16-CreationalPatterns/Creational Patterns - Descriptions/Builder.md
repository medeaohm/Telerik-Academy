##Builder Pattern##

The Builder Pattern is a **object creation** software design pattern. This pattern allows the client to construct a complex object, by knowing only his type and content, i.e. ingroting details about his creation like objects, their order of vreation, initialization etc. The complex object logic is hidden by the Builder, which can be used as an interface.

* **Motivation:**
The Builder pattern can be used when we have to create complex object, which contain other objects and the creation must be performed following a given procedure/logic.

* **Intent:**
Basically, the intent of the Builder design pattern is to separate the construction of a complex object from its representation. By doing so the same construction process can create different representations: the builder pattern define a class for object creation. However, the dicision about what kind of object must be created, should be left under the control of the classes which use it. The next class refers to the created object through a mutual interface. 

* **Applicability:**
The builder pattern could be adopted when:

	+ The algorithm for the creation of a complex object is indipendent of the logic for its contruction
	+ The process of contruction must allow us to create different versions of the object (using different elements or changig the order of creation 
	+ File System  

* **Known Uses:**
The builder pattern has the benefit that it can be used for objects that contain flat data i.e., data that can't be easily edited. 

	+ Construction of *HTML* documents
	+ *SQL* query
	+ *X.509* centificate

* **Implementation:**
The Builder Pattern is implemented throught a Builder class which defines an abstract interface for the creation of the different parts of the Product object and the Director class which create the Product object by using the Builder class.
  
	~~~c#
	using System;
	using System.Collections;

	  public class MainApp
	  {
	    public static void Main()
	    { 
	      // Create director and builders 
	      Director director = new Director();

	      Builder b1 = new ConcreteBuilder1();
	      Builder b2 = new ConcreteBuilder2();

	      // Construct two products 
	      director.Construct(b1);
	      Product p1 = b1.GetResult();
	      p1.Show();

	      director.Construct(b2);
	      Product p2 = b2.GetResult();
	      p2.Show();

	      // Wait for user 
	      Console.Read();
	    }
	  }

	  // "Director" 
	  class Director
	  {
	    // Builder uses a complex series of steps 
	    public void Construct(Builder builder)
	    {
	      builder.BuildPartA();
	      builder.BuildPartB();
	    }
	  }

	  // "Builder" 
	  abstract class Builder
	  {
	    public abstract void BuildPartA();
	    public abstract void BuildPartB();
	    public abstract Product GetResult();
	  }

	  // "ConcreteBuilder1" 
	  class ConcreteBuilder1 : Builder
	  {
	    private Product product = new Product();

	    public override void BuildPartA()
	    {
	      product.Add("PartA");
	    }

	    public override void BuildPartB()
	    {
	      product.Add("PartB");
	    }

	    public override Product GetResult()
	    {
	      return product;
	    }
	  }

	  // "ConcreteBuilder2" 
	  class ConcreteBuilder2 : Builder
	  {
	    private Product product = new Product();

	    public override void BuildPartA()
	    {
	      product.Add("PartX");
	    }

	    public override void BuildPartB()
	    {
	      product.Add("PartY");
	    }

	    public override Product GetResult()
	    {
	      return product;
	    }
	  }

	  // "Product" 
	  class Product
	  {
	    ArrayList parts = new ArrayList();

	    public void Add(string part)
	    {
	      parts.Add(part);
	    }

	    public void Show()
	    {
	      Console.WriteLine("\nProduct Parts -------");
	      foreach (string part in parts)
	        Console.WriteLine(part);
	    }
	  }
	~~~

* **Participants:**
When implementing the Singleton pattern the participants are the Singleton class and the client:
	* The Director class
	* The Builder interface
	* The Concrete Builder class

* **Consequences:**
	* Hides a complex funcionality needed for an object creation
	* It separates the algorithm used for the construction and thos used into the Product class
	* Good control on the precess of object contruction.

* **Related Patterns:**
	+ Simple Factory
	+ Factory Method
	+ Abstract Factory

* **Structure:**

![Builder](images/Builder.jpg "Builder - UML diagram")