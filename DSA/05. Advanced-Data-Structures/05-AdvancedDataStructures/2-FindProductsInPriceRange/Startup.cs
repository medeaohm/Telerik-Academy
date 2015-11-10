//2. Write a program to read a large collection of products(name + price) and efficiently find the first 20 products in the price range[a…b].
//  * Test for 500 000 products and 10 000 price searches.
//  * Hint: you may use `OrderedBag<T>` and sub-ranges.

namespace FindProductsInPriceRange
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Startup
    {
        private static readonly Stopwatch sw = new Stopwatch();

        public static void Main(string[] args)
        {
            // Test for 500 000 products and 10 000 price searches
            // Adding 500000 random products

            var store = new OrderedBag<Product>();
            var random = new RandomGenerator();

            Console.WriteLine("Adding 500,000 products to the store....");
            sw.Start();
            for (int i = 0; i < 500000; i++)
            { 
                var product = new Product(random.GetRandomString((int)random.GetRandomNumber(5, 20)), random.GetRandomNumber(1, 2000));
                store.Add(product);                
            }
            sw.Stop();
            Console.WriteLine("Elapsed time: {0}", sw.Elapsed);
            Console.WriteLine();

            Console.WriteLine("Performing 10,000 seaches into the store.....");
            sw.Reset();
            sw.Start(); 
            for (int i = 0; i < 10000; i++)
            {
                var findProducts = SearchProductsInPriceRange(store, random.GetRandomNumber(10, 50), random.GetRandomNumber(50, 100));
            }
            sw.Stop();
            Console.WriteLine("Elapsed time: {0}", sw.Elapsed);
            Console.WriteLine("Done!");
            Console.WriteLine();
        }

        private static ICollection<Product> SearchProductsInPriceRange(OrderedBag<Product> store, decimal min, decimal max)
        {
            return store.FindAll(p => p.Price >= min && p.Price <= max).Take(20).ToList();
        }
    }
}
