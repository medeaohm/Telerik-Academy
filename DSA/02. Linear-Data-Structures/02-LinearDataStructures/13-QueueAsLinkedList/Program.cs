﻿//13. Implement the ADT `queue` as dynamic linked list.
//  - Use generics(`LinkedQueue<T>`) to allow storing different data types in the queue.

namespace QueueAsLinkedList
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Queue<int> testQueue = new Queue<int>();

            testQueue.Enqueue(3);
            testQueue.Enqueue(4);
            testQueue.Enqueue(5);
            testQueue.Enqueue(6);
            testQueue.Dequeue();

            foreach (var item in testQueue)
            {
                Console.WriteLine("Item value: {0}", item);
            }

            Console.WriteLine("Queue items count: {0}", testQueue.Count);
        }
    }
}
