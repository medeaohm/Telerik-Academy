##Singleton Pattern##

The Singleton Pattern is a **creational** pattern: i.e. it concerns the creation of objects. The singleton pattern is also considerated as an **object** pattern, because it also controls connection between different objects. His main scope is to restrics the instantation of a class to one object.

* **Motivation:**
The necessity of the Singleton Pattern comes when we have to model real world objects which have a unique instance.  

* **Intent:**
The intents of the singleton pattern are basically two:

	+ It assures the creation of a unique istance for a given class
	+ It allows to access this istance

* **Applicability:**
The applicability ogthe singleton pattern comes when we have different request for mutual resurs, so ther is a necessity of centralizing them. For example:

	+ Games highscores
	+ File System  

* **Known Uses:**
The Singleton pattern can be used in the following cases:

	+ *Logger* classes
	+ When we have to access a given resource (for example a serial port)
	+ *Configuration* classes

* **Implementation:**
	* Singleton - _simple thread-safety_
	The Singleton Pattern is iplemented using a *static field* into the Sigleton class, a *private constructor* and a *static public method* 	which results in a reference of the static field.
  
	~~~c#
	public sealed class Singleton
	{
	    private static Singleton instance = null;
	    private static readonly object padlock = new object();

	    Singleton()
	    {
	    }

	    public static Singleton Instance
	    {
	        get
	        {
	            lock (padlock)
	            {
	                if (instance == null)
	                {
	                    instance = new Singleton();
	                }
	                return instance;
	            }
	        }
	    }
	}
	~~~

* **Participants:**
When implementing the Singleton pattern the participants are the Singleton class and the client:
	* The singleton class defines a method which allows us to access to its unique instance. This instance is realized using a static method which is responsable og the unique initialization of the class.
	*The client is allowed to access to the Singleton class only thought the static field

* **Consequences:**
	* The basic implementation is not thread-safe
	* Tight coupling: it depends of the Singleton class
	* Compared to the global variables, the Singleton class give to us more funcionalities
	* Controled access of the client to the unique instance of the Singleton class

* **Related Patterns:**
The Singleton pattern can be used with Abstract Factory pattern or Factory Method pattern.

* **Structure:**

![Singleton](images/Singleton.gif "Singleton - UML diagram")