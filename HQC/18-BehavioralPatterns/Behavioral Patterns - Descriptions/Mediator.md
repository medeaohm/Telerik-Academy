##Mediator Pattern##

In Software Engineering, the mediator pattern defines an object that encapsulates how a set of objects interact. This pattern is considered to be a behavioral pattern due to the way it can alter the program's running behavior.

* **Motivation:**
	+ Simplifies communication between classes
	+ Using one centralized component (the Mediator)
	+ Define an object that encapsulates how a set of objects interact with each other
	+ Without having these objects to have intimate knowledge about each others
	+ Promotes loose coupling by keeping objects from referring to each other explicitly
	+ Lets you vary their interaction independently

* **Intent:**
Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.
Design an intermediary to decouple many peers.
Promote the many-to-many relationships between interacting peers to "full object status".

* **Applicability:**
The Mediator pattern can be used when:
	+  a set of object communicate in well-defined but complex ways. The resulting interdependencies are unstructrured and difficult to understand
	+ reusing an object is difficult because it refers to and communicates with many other objects
	+ a behavior that's distributed between several classes should be customicable without a lot of subclassing

* **Implementation:**
 
	~~~c#
	using System;
 
	namespace DoFactory.GangOfFour.Mediator.Structural
	{
	  /// <summary>
	  /// MainApp startup class for Structural 
	  /// Mediator Design Pattern.
	  /// </summary>
	  class MainApp
	  {
	    /// <summary>
	    /// Entry point into console application.
	    /// </summary>
	    static void Main()
	    {
	      ConcreteMediator m = new ConcreteMediator();
	 
	      ConcreteColleague1 c1 = new ConcreteColleague1(m);
	      ConcreteColleague2 c2 = new ConcreteColleague2(m);
	 
	      m.Colleague1 = c1;
	      m.Colleague2 = c2;
	 
	      c1.Send("How are you?");
	      c2.Send("Fine, thanks");
	 
	      // Wait for user
	      Console.ReadKey();
	    }
	  }
	 
	  /// <summary>
	  /// The 'Mediator' abstract class
	  /// </summary>
	  abstract class Mediator
	  {
	    public abstract void Send(string message,
	      Colleague colleague);
	  }
	 
	  /// <summary>
	  /// The 'ConcreteMediator' class
	  /// </summary>
	  class ConcreteMediator : Mediator
	  {
	    private ConcreteColleague1 _colleague1;
	    private ConcreteColleague2 _colleague2;
	 
	    public ConcreteColleague1 Colleague1
	    {
	      set { _colleague1 = value; }
	    }
	 
	    public ConcreteColleague2 Colleague2
	    {
	      set { _colleague2 = value; }
	    }
	 
	    public override void Send(string message,
	      Colleague colleague)
	    {
	      if (colleague == _colleague1)
	      {
	        _colleague2.Notify(message);
	      }
	      else
	      {
	        _colleague1.Notify(message);
	      }
	    }
	  }
	 
	  /// <summary>
	  /// The 'Colleague' abstract class
	  /// </summary>
	  abstract class Colleague
	  {
	    protected Mediator mediator;
	 
	    // Constructor
	    public Colleague(Mediator mediator)
	    {
	      this.mediator = mediator;
	    }
	  }
	 
	  /// <summary>
	  /// A 'ConcreteColleague' class
	  /// </summary>
	  class ConcreteColleague1 : Colleague
	  {
	    // Constructor
	    public ConcreteColleague1(Mediator mediator)
	      : base(mediator)
	    {
	    }
	 
	    public void Send(string message)
	    {
	      mediator.Send(message, this);
	    }
	 
	    public void Notify(string message)
	    {
	      Console.WriteLine("Colleague1 gets message: "
	        + message);
	    }
	  }
	 
	  /// <summary>
	  /// A 'ConcreteColleague' class
	  /// </summary>
	  class ConcreteColleague2 : Colleague
	  {
	    // Constructor
	    public ConcreteColleague2(Mediator mediator)
	      : base(mediator)
	    {
	    }
	 
	    public void Send(string message)
	    {
	      mediator.Send(message, this);
	    }
	 
	    public void Notify(string message)
	    {
	      Console.WriteLine("Colleague2 gets message: "
	        + message);
	    }
	  }
	}
 
	~~~

* **Participants:**
	+ ***Mediator*** - defines the interface for communication between Colleague objects
	+ ***ConcreteMediator*** - implements the Mediator interface and coordinates communication between Colleague objects. It is aware of all the Colleagues and their purpose with regards to inter communication.
	+ ***ConcreteColleague*** - communicates with other Colleagues through its Mediator

* **Consequences:**
	+	Advantages
		+	Hides all coordination between colleagues
		+ Separation of concerns
		+ Decouples colleagues
		+ One-to-many relationship is preferred to many-to-many fashion
	+ Disadvantages
		+ The Mediator can become very large (fat) and very complicated as more logic is handled or as more type of colleagues are handled

* **Structure:**

![Mediator](http://www.dofactory.com/images/diagrams/net/mediator.gif" Mediator - UML Diagram")
