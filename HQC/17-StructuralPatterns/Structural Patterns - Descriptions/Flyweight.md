##Flyweight Pattern##

In computer programming, flyweight is a software design pattern. A flyweight is an object that minimizes memory use by sharing as much data as possible with other similar objects; it is a way to use objects in large numbers when a simple repeated representation would use an unacceptable amount of memory. Often some parts of the object state can be shared, and it is common practice to hold them in external data structures and pass them to the flyweight objects temporarily when they are used.


* **Motivation:**
Some programs require a large number of objects that have some shared state among them. Consider for example a game of war, were there is a large number of soldier objects; a soldier object maintain the graphical representation of a soldier, soldier behavior such as motion, and firing weapons, in addition soldier's health and location on the war terrain. Creating a large number of soldier objects is a necessity however it would incur a huge memory cost. Note that although the representation and behavior of a soldier is the same their health and location can vary greatly.

* **Intent:**
The intent of this pattern is to use sharing to support a large number of objects that have part of their internal state in common where the other part of state can vary.

* **Applicability:**
The flyweight pattern applies to a program using a huge number of objects that have part of their internal state in common where the other part of state can vary. The pattern is used when the larger part of the object's state can be made extrinsic (external to that object).

* **Known Uses:**
	+ Games with graphics 
	+ Text Editors 

* **Implementation:**
 
	~~~c#
	using System;
	using System.Collections;
	
	  class MainApp
	  {
		    static void Main()
		    {
			      // Arbitrary extrinsic state 
			      int extrinsicstate = 22;
			 
			      FlyweightFactory f = new FlyweightFactory();
			
			      // Work with different flyweight instances 
			      Flyweight fx = f.GetFlyweight("X");
			      fx.Operation(--extrinsicstate);
			
			      Flyweight fy = f.GetFlyweight("Y");
			      fy.Operation(--extrinsicstate);
			
			      Flyweight fz = f.GetFlyweight("Z");
			      fz.Operation(--extrinsicstate);
			
			      UnsharedConcreteFlyweight uf = new UnsharedConcreteFlyweight();
			
			      uf.Operation(--extrinsicstate);
			
			      // Wait for user 
			      Console.Read();
		    }
	  }
	
	  // "FlyweightFactory" 
	  class FlyweightFactory 
	  {
		    private Hashtable flyweights = new Hashtable();
		
		    // Constructor 
		    public FlyweightFactory()
		    {
			      flyweights.Add("X", new ConcreteFlyweight());    
			      flyweights.Add("Y", new ConcreteFlyweight());
			      flyweights.Add("Z", new ConcreteFlyweight());
		    }
		
		    public Flyweight GetFlyweight(string key)
		    {
			      return((Flyweight)flyweights[key]); 
		    }
	  }
	
	  // "Flyweight" 
	  abstract class Flyweight 
	  {
		    public abstract void Operation(int extrinsicstate);
	  }
	
	  // "ConcreteFlyweight" 
	
	  class ConcreteFlyweight : Flyweight
	  {
		    public override void Operation(int extrinsicstate)
		    {
			      Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
		    }
	  }
	
	  // "UnsharedConcreteFlyweight" 
	  class UnsharedConcreteFlyweight : Flyweight
	  {
		    public override void Operation(int extrinsicstate)
		    {
			      Console.WriteLine("UnsharedConcreteFlyweight: " + extrinsicstate);
		    }
	  }
	~~~

* **Participants:**
	+ **Flyweight** - Declares an interface through which flyweights can receive and act on extrinsic state.
	+ **ConcreteFlyweight** - Implements the Flyweight interface and stores intrinsic state. A ConcreteFlyweight object must be sharable. The Concrete flyweight object must maintain state that it is intrinsic to it, and must be able to manipulate state that is extrinsic. 
	+ **FlyweightFactory** - The factory creates and manages flyweight objects. In addition the factory ensures sharing of the flyweight objects. The factory maintains a pool of different flyweight objects and returns an object from the pool if it is already created, adds one to the pool and returns it in case it is new.
	+ **Client** - A client maintains references to flyweights in addition to computing and maintaining extrinsic state

* **Consequences:**
Flyweight pattern saves memory by sharing flyweight objects among clients. The amount of memory saved generally depends on the number of flyweight categories saved (for example a soldier category and a lieutenant category as discussed earlier).

* **Related Patterns:**
	+ ***Factory and Singleton patterns*** - Flyweights are usually created using a factory and the singleton is applied to that factory so that for each type or category of flyweights a single instance is returned.
	+ ***State and Strategy Patterns*** - State and Strategy objects are usually implemented as Flyweights.

* **Structure:**

![Flyweight](http://www.dofactory.com/images/diagrams/net/flyweight.gif" Flyweight- UML Diagram")