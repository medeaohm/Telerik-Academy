// 1. Implement a class `PriorityQueue<T>` based on the data structure "binary heap".

namespace AdvancedDataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        

        public static void Main()
        {
            PriorityQueue<ItemWithPriority> priorityQueue = new PriorityQueue<ItemWithPriority>();

            ItemWithPriority item1 = new ItemWithPriority("Divan", 2.0);
            ItemWithPriority item2 = new ItemWithPriority("Leglo", 1.0);
            ItemWithPriority item3 = new ItemWithPriority("Masa", 3.0);

            Console.WriteLine("Adding " + item1.ToString() + " to priority queue");
            priorityQueue.Enqueue(item1);
            Console.WriteLine("Adding " + item2.ToString() + " to priority queue");
            priorityQueue.Enqueue(item2);
            Console.WriteLine("Adding " + item3.ToString() + " to priority queue");
            priorityQueue.Enqueue(item3);


            if (priorityQueue.Count() > 0)
            {
                ItemWithPriority item = priorityQueue.Peek();
                Console.WriteLine("The front item is " + item.ToString());
            }
        }
    }
}
