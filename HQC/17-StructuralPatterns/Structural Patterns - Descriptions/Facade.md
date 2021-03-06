##Façade Pattern##

The façade pattern (or facade pattern) is a software design pattern commonly used with object-oriented programming. The name is by analogy to an architectural facade.

A facade is an object that provides a simplified interface to a larger body of code, such as a class library.

* **Motivation:**
The Facade design pattern is often used when a system is very complex or difficult to understand because the system has a large number of interdependent classes or its source code is unavailable. This pattern hides the complexities of the larger system and provides a simpler interface to the client. It typically involves a single wrapper class which contains a set of members required by client. These members access the system on behalf of the facade client and hide the implementation details.

* **Intent:**
A facade can:
	+ make a software library easier to use, understand and test, since the facade has convenient methods for common tasks;
	+ make the library more readable, for the same reason;
	+ reduce dependencies of outside code on the inner workings of a library, since most code uses the facade, thus allowing more flexibility in developing the system;
	+ wrap a poorly designed collection of APIs with a single well-designed API.

* **Applicability:**
The facade pattern is typically used when:
	+ a simple interface is required to access a complex system;
	+ the abstractions and implementations of a subsystem are tightly coupled; 
	+ or a system is very complex or difficult to understand.

* **Known Uses:**
Façade pattern used:
	+  in many Win32 API based classes to hide Win32 complexity
	+ In XmlSerializer (in .NET) and JSON serializer (in JSON.NET) hides a complex task (that includes generatingassemblies on thefly!) behind a veryeasy-to-use class.
	+ WebClient, File 

	
* **Implementation:**
 
	~~~c#
		using System;
     
    	namespace DoFactory.GangOfFour.Facade.Structural
    	{
    	  /// <summary>
    	  /// MainApp startup class for Structural
    	  /// Facade Design Pattern.
    	  /// </summary>
    			  class MainApp
    			  {
    			    /// <summary>
    			    /// Entry point into console application.
    			    /// </summary>
    			    public static void Main()
    			    {
    					      Facade facade = new Facade();
    					 
    					      facade.MethodA();
    					      facade.MethodB();
    				 
    					      // Wait for user
    					      Console.ReadKey();
    				    }
    			  }
    			 
    			  /// <summary>
    			  /// The 'Subsystem ClassA' class
    			  /// </summary>
    			  class SubSystemOne
    			  {
    				    public void MethodOne()
    				    {
    					      Console.WriteLine(" SubSystemOne Method");
    				    }
    			  }
    			 
    			  /// <summary>
    			  /// The 'Subsystem ClassB' class
    			  /// </summary>
    			  class SubSystemTwo
    			  {
    				    public void MethodTwo()
    				    {
    					      Console.WriteLine(" SubSystemTwo Method");
    				    }
    			  }
    			 
    			  /// <summary>
    			  /// The 'Subsystem ClassC' class
    			  /// </summary>
    			  class SubSystemThree
    			  {
    				    public void MethodThree()
    				    {
    					      Console.WriteLine(" SubSystemThree Method");
    				    }
    			  }
    			 
    			  /// <summary>
    			  /// The 'Subsystem ClassD' class
    			  /// </summary>
    			  class SubSystemFour
    			  {
    			    public void MethodFour()
    			    {
    				      Console.WriteLine(" SubSystemFour Method");
    			    }
    			  }
    			 
    			  /// <summary>
    			  /// The 'Facade' class
    			  /// </summary>
    			  class Facade
    			  {
    				    private SubSystemOne one;
    				    private SubSystemTwo two;
    				    private SubSystemThree three;
    				    private SubSystemFour four;
    			 
    			    public Facade()
    			    {
    				      one = new SubSystemOne();
    				      two = new SubSystemTwo();
    				      three = new SubSystemThree();
    				      four = new SubSystemFour();
    			    }
    			 
    			    public void MethodA()
    			    {
    			      Console.WriteLine("\nMethodA() ---- ");
    				      one.MethodOne();
    				      two.MethodTwo();
    				      four.MethodFour();
    			    }
    			 
    			    public void MethodB()
    			    {
    			      Console.WriteLine("\nMethodB() ---- ");
    				      two.MethodTwo();
    				      three.MethodThree();
    			    }
    		  }
    	}
	~~~

* **Participants:**
The classes and objects participating in this pattern are:
	+ Facade   (MortgageApplication)
		+ knows which subsystem classes are responsible for a request.
		+ delegates client requests to appropriate subsystem objects.
	+ Subsystem classes   (Bank, Credit, Loan)
		+ implement subsystem functionality.
		+ handle work assigned by the Facade object.
		+ have no knowledge of the facade and keep no reference to it.

* **Consequences:**
The Facade simplifies the use of the required subsystem. However, because
the Facade is not complete, certain functionality may be unavailable
to the client. 

* **Related Patterns:**
	+ ***Adapter: *** 	Converts one interface to another so that it matches what the client is expecting
	+ ***Decorator:***	Dynamically adds responsibility to the interface by wrapping the original code

* **Structure:**

![Façade](https://en.wikipedia.org/wiki/Facade_pattern#/media/File:Example_of_Facade_design_pattern_in_UML.png "Façade - UML Diagram")