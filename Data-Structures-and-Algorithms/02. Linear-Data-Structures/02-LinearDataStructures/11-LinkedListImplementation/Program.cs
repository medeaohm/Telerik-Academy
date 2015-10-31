//11. Implement the data structure linked list.
//  - Define a class `ListItem<T>` that has two fields: `value` (of type `T`) and `NextItem` (of type `ListItem<T>`). 
//  - Define additionally a class `LinkedList<T>` with a single field `FirstElement` (of type `ListItem<T>`).

namespace LinkedListImplementation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            LinkedList<int> testLinkedList = new LinkedList<int>();

            testLinkedList.AddFirst(5);
            testLinkedList.AddFirst(4);
            testLinkedList.AddLast(6);
            testLinkedList.AddLast(7);
            testLinkedList.RemoveFirst();
            testLinkedList.RemoveLast();

            foreach (var item in testLinkedList)
            {
                Console.WriteLine("Item value: {0}", item);
            }

            Console.WriteLine("Linked list items count: {0}", testLinkedList.Count());
        }
    }
}
