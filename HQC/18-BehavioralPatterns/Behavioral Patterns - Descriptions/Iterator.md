##Iterator Pattern##

In object-oriented programming, the iterator pattern is a design pattern in which an iterator is used to traverse a container and access the container's elements.

* **Motivation:**
The iterator pattern decouples algorithms from containers; in some cases, algorithms are necessarily container-specific and thus cannot be decoupled.

* **Intent:**
Provide an object which traverses some aggregate structure, abstracting away assumptions about the implementation of that structure.
The simplest iterator has a "next element" method, which returns elements in some sequential order until there are no more. More sophisticated iterators might allow several directions and types of movement through a complex structure.

* **Applicability:**
Typically an iterator has three tasks that might or might not be implemented in separate methods:
	+ Testing whether elements are available
	+ Advancing to the next n.th position
	+ Accessing the value at the current position
	
	Bidirectional iterators might have additional methods for checking and advancing the reverse direction.

* **Implementation:**
 
	~~~c#
	using System;
using System.Collections;
 
namespace DoFactory.GangOfFour.Iterator.Structural
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Iterator Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";
 
            // Create Iterator and provide aggregate
            ConcreteIterator i = new ConcreteIterator(a);
 
            Console.WriteLine("Iterating over collection:");
 
            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
 
            // Wait for user
            Console.ReadKey();
        }
    }
 
    /// <summary>
    /// The 'Aggregate' abstract class
    /// </summary>
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
 
    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();
 
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
 
        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }
 
        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
 
    /// <summary>
    /// The 'Iterator' abstract class
    /// </summary>
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
 
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;
 
        // Constructor
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }
 
        // Gets first iteration item
        public override object First()
        {
            return _aggregate[0];
        }
 
        // Gets next iteration item
        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }
 
            return ret;
        }
 
        // Gets current iteration item
        public override object CurrentItem()
        {
            return _aggregate[_current];
        }
 
        // Gets whether iterations are complete
        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
}
	~~~

* **Participants:**
*The classes and objects participating in this pattern are:
	+ ***Iterator  (AbstractIterator):*** defines an interface for accessing and traversing elements.
	+ ***ConcreteIterator  (Iterator):*** implements the Iterator interface.
keeps track of the current position in the traversal of the aggregate. 
	+ ***Aggregate  (AbstractCollection):*** defines an interface for creating an Iterator object
	+ ***ConcreteAggregate  (Collection):***
implements the Iterator creation interface to return an instance of the proper ConcreteIterator

* **Structure:**

![Iterator](https://it.wikipedia.org/wiki/Iterator_pattern#/media/File:IteratorPattern.png" Iterator- UML Diagram")