##Decorator Pattern##

In object-oriented programming, the **decorator** pattern (also known as *Wrapper*, an alternative naming shared with the Adapter pattern) is a design pattern that allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class.

The decorator pattern is often useful for adhering to the Single Responsibility Principle, as it allows functionality to be divided between classes with unique areas of concern

* **Motivation:**
Extending an object's functionality can be done statically (at compile time) by using inheritance however it might be necessary to extend an object's functionality dynamically (at runtime) as an object is used.
Consider the typical example of a graphical window. To extend the functionality of the graphical window for example by adding a frame to the window, would require extending the window class to create a FramedWindow class. To create a framed window it is necessary to create an object of the FramedWindow class. However it would be impossible to start with a plain window and to extend its functionality at runtime to become a framed window.

* **Intent:**
The decorator pattern can be used to extend (decorate) the functionality of a certain object statically, or in some cases at run-time, independently of other instances of the same class, provided some groundwork is done at design time. This is achieved by designing a new decorator class that wraps the original class. This wrapping could be achieved by the following sequence of steps:
	+ Subclass the original "Component" class into a "Decorator" class (see UML diagram);
	+ In the Decorator class, add a Component pointer as a field;
	+ Pass a Component to the Decorator constructor to initialize the Component pointer;
	+ In the Decorator class, redirect all "Component" methods to the "Component" pointer; 
	+ In the ConcreteDecorator class, override any Component method(s) whose behavior needs to be modified.

	This pattern is designed so that multiple decorators can be stacked on top of each other, each time adding a new functionality to the overridden method(s).
The decoration features (e.g., methods, properties, or other members) are usually defined by an interface, mixin or class inheritance which is shared by the decorators and the decorated object.


* **Applicability:**
The decorator pattern is an alternative to subclassing. Subclassing adds behavior at compile time, and the change affects all instances of the original class; decorating can provide new behavior at run-time for selective objects.

* **Known Uses:**
Some uses of the decorator pattern are:
	+ Applicable in legacy systems
	+ Used to add functionality to UI controls
	+ Can be used to extend sealed classes
	+ In .NET: CryptoStream and GZipStream decorates Stream
	+ In WPF Decorator class provides a base class for elements that apply effects onto or around a single child element, such as Border or Viewbox


* **Implementation:**
 
	~~~c#
	using System;

	 class MainApp
	 {
			 static void Main()
		     {
			      // Create ConcreteComponent and two Decorators 
			      ConcreteComponent c = new ConcreteComponent();
			      ConcreteDecoratorA d1 = new ConcreteDecoratorA();
			      ConcreteDecoratorB d2 = new ConcreteDecoratorB();
		
			      // Link decorators 
			      d1.SetComponent(c);
			      d2.SetComponent(d1);
			
			      d2.Operation();
			
			      // Wait for user 
			      Console.Read();
		    }
	  }
	
	  // "Component" 
	  abstract class Component
	  {
		  public abstract void Operation();
	  }
	
	  // "ConcreteComponent" 
	  class ConcreteComponent : Component
	  {
		    public override void Operation()
		    {
			    Console.WriteLine("ConcreteComponent.Operation()");
		    }
	  }

	  // "Decorator" 
	  abstract class Decorator : Component
	  {
		    protected Component component;
		
		    public void SetComponent(Component component)
		    {
			    this.component = component;
		    }
		
		    public override void Operation()
		    {
			      if (component != null)
			      {
				        component.Operation();
			      }
		    }
	  }
	
	  // "ConcreteDecoratorA" 
	  class ConcreteDecoratorA : Decorator
	  {
		    private string addedState;
		
		    public override void Operation()
		    {
			      base.Operation();
			      addedState = "New State";
			      Console.WriteLine("ConcreteDecoratorA.Operation()");
		    }
	  }
	
	  // "ConcreteDecoratorB" 
	  class ConcreteDecoratorB : Decorator
	  {
		    public override void Operation()
		    {
			      base.Operation();
			      AddedBehavior();
			      Console.WriteLine("ConcreteDecoratorB.Operation()");
		    }
	
		    void AddedBehavior()
		    {
		    }
    }
	~~~

* **Participants:**
The participants classes in the decorator pattern are:
	+ **Component** - Interface for objects that can have responsibilities added to them dynamically.
	+ **ConcreteComponent** - Defines an object to which additional responsibilities can be added.
	+ **Decorator** - Maintains a reference to a Component object and defines an interface that conforms to Component's interface.
	+ **Concrete Decorators** - Concrete Decorators extend the functionality of the component by adding state or adding behavior.

* **Consequences:**
Some consequences are:
	+ Decoration is more convenient for adding functionalities to objects instead of entire classes at runtime. With decoration it is also possible to remove the added functionalities dynamically.
	+ Decoration adds functionality to objects at runtime which would make debugging system functionality harder.

* **Related Patterns:**
	+ **Adapter Pattern** - A decorator is different from an adapter in that a decorator changes object's responsibilities, while an adapter changes an object interface.
	+ **Composite Pattern** - A decorator can be viewed as a degenerate composite with only one component. However, a decorator adds additional responsibilities.

* **Structure:**

![Decorator](https://en.wikipedia.org/wiki/Decorator_pattern#/media/File:Decorator_UML_class_diagram.svg "Decorator - UML Diagram")
