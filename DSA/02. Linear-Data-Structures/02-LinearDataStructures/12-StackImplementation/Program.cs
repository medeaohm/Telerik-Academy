﻿//12. Implement the ADT `stack` as auto-resizable array.
//  - Resize the capacity on demand (when no space is available to add / insert a new element).

namespace StackImplementation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Stack<int> testStack = new Stack<int>();

            testStack.Push(5);
            testStack.Push(4);
            testStack.Push(3);
            testStack.Push(2);
            testStack.Pop();

            foreach (var item in testStack)
            {
                Console.WriteLine("Item value: {0}", item);
            }

            Console.WriteLine("Stack items count: {0}", testStack.Count);
            Console.WriteLine("Stack capacity: {0}", testStack.Capacity);

            testStack.Push(6);
            testStack.Push(7);

            Console.WriteLine(new string('-', 15));
            Console.WriteLine("After adding 2 more items");
            Console.WriteLine("Stack items count: {0}", testStack.Count);
            Console.WriteLine("Stack capacity: {0}", testStack.Capacity);
        }
    }
}
