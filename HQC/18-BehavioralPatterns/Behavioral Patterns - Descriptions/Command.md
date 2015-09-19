##Command Pattern##

In object-oriented programming, the command pattern is a behavioral design pattern in which an object is used to encapsulate all information needed to perform an action or trigger an event at a later time. This information includes the method name, the object that owns the method and values for the method parameters.

* **Motivation:**
The Command pattern is an object that encapsulates all the information needed to call a method at a later time:
	+	Represents an action (request) as an object
	+	Decouples clients that execute the command from the details and dependencies of the command logic
	+	Can log requests
	+	Can queue commandsfor later execution
	+	Can validate requests
	+	Support for undoable operations, etc.

* **Intent:**
The intents of the Command pattern are:
	+ encapsulate a request in an object 
	+ allows the parameterization of clients with different requests
	+ allows saving the requests in a queue
	+ Promote "invocation of a method on an object" to full object status
	+ An object-oriented callback

* **Applicability:**
The applicability of the Command design pattern can be found in these cases below:
	+ parameterizes objects depending on the action they must perform
	+ specifies or adds in a queue and executes requests at different moments in time
	+ offers support for undoable actions (the Execute method can memorize the state and allow going back to that state)
	+ structures the system in high level operations that based on primitive operations
	+ decouples the object that invokes the action from the object that performs the action. Due to this usage it is also known as Producer - Consumer design pattern.

* **Implementation:**
 
	~~~c#
	using System;
	using System.Collections.Generic;
	
	namespace CommandPattern
	{
	    public interface ICommand
	    {
	        void Execute();
	    }
	
	    /* The Invoker class */
	    public class Switch
	    {
	        ICommand _closedCommand;
	        ICommand _openedCommand;
	
	        public Switch(ICommand closedCommand, ICommand openedCommand)
	        {
	            _closedCommand = closedCommand;
	            _openedCommand = openedCommand;
	
	        }
	
	        //close the circuit/power on
	        public void Close()
	        {
	            _closedCommand.Execute();
	        }
	
	        //open the circuit/power off
	        public void Open()
	        {
	            _openedCommand.Execute();
	        }
	    }
	    
	    /* An interface that defines actions that the receiver can perform */
	    public interface ISwitchable
	    {
	        void PowerOn();
	        void PowerOff();
	    }
	
	    /* The Receiver class */
	    public class Light : ISwitchable
	    {
	        public void PowerOn()
	        {
	            Console.WriteLine("The light is on");
	        }
	
	        public void PowerOff()
	        {
	            Console.WriteLine("The light is off");
	        }
	    }
	
	    /* The Command for turning on the device - ConcreteCommand #1 */
	    public class CloseSwitchCommand: ICommand
	    {
	        private ISwitchable _switchable;
	
	        public CloseSwitchCommand(ISwitchable switchable)
	        {
	            _switchable = switchable;
	        }
	
	        public void Execute()
	        {
	            _switchable.PowerOn();
	        }
	    }
	
	    /* The Command for turning off the device - ConcreteCommand #2 */
	    public class OpenSwitchCommand : ICommand
	    {
	        private ISwitchable _switchable;
	
	        public OpenSwitchCommand(ISwitchable switchable)
	        {
	            _switchable = switchable;
	        }
	
	        public void Execute()
	        {
	            _switchable.PowerOff();
	        }
	    }
	
	    /* The test class or client */
	    internal class Program
	    {
	        public static void Main(string[] args)
	        {
	            string arg = args.Length > 0 ? args[0].ToUpper() : null;
	
	            ISwitchable lamp = new Light();
	
	            //Pass reference to the lamp instance to each command
	            ICommand switchClose = new CloseSwitchCommand(lamp);
	            ICommand switchOpen = new OpenSwitchCommand(lamp);
	
	
	            //Pass reference to instances of the Command objects to the switch
	            Switch @switch = new Switch(switchClose, switchOpen);
	
	            
	            if (arg == "ON")
	            {
	                //Switch (the Invoker) will invoke Execute() (the Command) on the command object - _closedCommand.Execute();
	                @switch.Close();
	            }
	            else if (arg == "OFF")
	            {
	                //Switch (the Invoker) will invoke the Execute() (the Command) on the command object - _openedCommand.Execute();
	                @switch.Open();
	            }
	            else
	            {
	                Console.WriteLine("Argument \"ON\" or \"OFF\" is required.");
	            }
	        }
	    }
	}
	~~~

* **Participants:**
 The classes participating in the pattern are: 
	 + ***Command*** - declares an interface for executing an operation;
	 + ***ConcreteCommand*** - extends the Command interface, implementing the Execute method by invoking the corresponding operations on Receiver. It defines a link between the Receiver and the action. 
	 + ***Client*** - creates a ConcreteCommand object and sets its receiver;
	 + ***Invoker*** - asks the command to carry out the request;
	 + ***Receiver*** - knows how to perform the operations;

* **Consequences:**
	+ Since Commands are encapsulated, their number and implementations can vary.
	+ Commands have independent lifetimes. Thus they can be queued, stored, or transmitted.
	+ Commands can encapsulate their own undo procedure, or the log can be replayed to simulate undo.
	+ Commands can be assembled into macros and scripts, which are also Commands. This is one way to represent atomic transactions. The composite Command registers its start and end in the log. If an error or failure occurs in the middle, all Commands are undone up to the start marker.
	+ A Command can play the role of a Strategy or callback, decoupling the issuer of the Command from the Command's implementation. For example, a button can initiate an arbitrary operation depending on what its Command Strategy was. The same Command can come from several different sources.

* **Related Patterns:**
	+ Factory Pattern
		+ Factories can be used to construct commands
	+ Null Object
		+ Returning “null command” can be useful instead of returning null
	+ Composite
		+ Can be useful to construct command with child commands
			+ Execute() should call Execute() of all child commands


* **Structure:**

![Command](http://www.lcc.uma.es/~amg/ISE/OOP-Java-UML/Chapter%207_archivos/7-Command.gif" Command - UML Diagram")