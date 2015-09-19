##Strategy Pattern##

In computer programming, the strategy pattern (also known as the policy pattern) is a software design pattern that enables an algorithm's behavior to be selected at runtime. 
The strategy pattern:
	+ defines a family of algorithms
	+ encapsulates each algorithm
	+ makes the algorithms interchangeable within that family.

* **Motivation:**
There are common situations when classes differ only in their behavior. For this cases is a good idea to isolate the algorithms in separate classes in order to have the ability to select different algorithms at runtime. 

* **Intent:**
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

* **Applicability:**
For instance, a class that performs validation on incoming data may use a strategy pattern to select a validation algorithm based on the type of data, the source of the data, user choice, or other discriminating factors. These factors are not known for each case until run-time, and may require radically different validation to be performed. The validation strategies, encapsulated separately from the validating object, may be used by other validating objects in different areas of the system (or even different systems) without code duplication.

* **Implementation:**
 
	~~~c#
	using System;
 
	namespace DoFactory.GangOfFour.Strategy.Structural
	{
	  /// <summary>
	  /// MainApp startup class for Structural
	  /// Strategy Design Pattern.
	  /// </summary>
	  class MainApp
	  {
	    /// <summary>
	    /// Entry point into console application.
	    /// </summary>
	    static void Main()
	    {
	      Context context;
	 
	      // Three contexts following different strategies
	      context = new Context(new ConcreteStrategyA());
	      context.ContextInterface();
	 
	      context = new Context(new ConcreteStrategyB());
	      context.ContextInterface();
	 
	      context = new Context(new ConcreteStrategyC());
	      context.ContextInterface();
	 
	      // Wait for user
	      Console.ReadKey();
	    }
	  }
 
	  /// <summary>
	  /// The 'Strategy' abstract class
	  /// </summary>
	  abstract class Strategy
	  {
	    public abstract void AlgorithmInterface();
	  }
	 
	  /// <summary>
	  /// A 'ConcreteStrategy' class
	  /// </summary>
	  class ConcreteStrategyA : Strategy
	  {
	    public override void AlgorithmInterface()
	    {
	      Console.WriteLine(
	        "Called ConcreteStrategyA.AlgorithmInterface()");
	    }
	  }
 
	  /// <summary>
	  /// A 'ConcreteStrategy' class
	  /// </summary>
	  class ConcreteStrategyB : Strategy
	  {
	    public override void AlgorithmInterface()
	    {
	      Console.WriteLine(
	        "Called ConcreteStrategyB.AlgorithmInterface()");
	    }
	  }
	 
	  /// <summary>
	  /// A 'ConcreteStrategy' class
	  /// </summary>
	  class ConcreteStrategyC : Strategy
	  {
	    public override void AlgorithmInterface()
	    {
	      Console.WriteLine(
	        "Called ConcreteStrategyC.AlgorithmInterface()");
	    }
	  }
 
	  /// <summary>
	  /// The 'Context' class
	  /// </summary>
	  class Context
	  {
	    private Strategy _strategy;
	 
	    // Constructor
	    public Context(Strategy strategy)
	    {
	      this._strategy = strategy;
	    }
	 
	    public void ContextInterface()
	    {
	      _strategy.AlgorithmInterface();
	    }
	  }
	}
	~~~

* **Participants:**
 The classes and objects participating in this pattern are:
	 + ***Strategy  (SortStrategy)***: declares an interface common to all supported algorithms. Context uses this interface to call the algorithm defined by a ConcreteStrategy
	 + ***ConcreteStrategy***  (QuickSort, ShellSort, MergeSort) implements the algorithm using the Strategy interface 
	 + ***Context  (SortedList)*** is configured with a ConcreteStrategy object
maintains a reference to a Strategy object
may define an interface that lets Strategy access its data.

* **Consequences:**
Strategy lets the algorithm vary independently from clients that use it.


* **Structure:**

![Strategy](http://www.dofactory.com/images/diagrams/net/strategy.gif" Strategy- UML Diagram")