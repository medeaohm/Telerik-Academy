//1. Write a program based on dynamic programming to solve the "**Knapsack Problem**": you are given `N` products, each has weight `W`<sub>`i`</sub> and costs `C`<sub>`i`</sub> and a knapsack of capacity `M` and you want to put inside a subset of the products with highest cost and `weight ≤ M`. The numbers `N`, `M`, `W`<sub>`i`</sub> and `C`<sub>`i`</sub> are integers in the range `[1..500]`.
//  * _Example_: `M=10kg`, `N=6`, products:
//      * beer – weight=3, cost=2
//      * vodka – weight=8, cost=12
//      * cheese – weight=4, cost=5
//      * `nuts – weight=1, cost=4`
//      * ham – weight=2, cost=3
//      * `whiskey – weight=8, cost=13`
//  * _Optimal solution_:
//      * nuts + whiskey
//      * weight = 9
//      * cost = 17

namespace KnapSackProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            List<Item> items = new List<Item>();

            items.Add(new Item("beer", 3, 2));
            items.Add(new Item("vodka", 8, 12));
            items.Add(new Item("cheese", 4, 5));
            items.Add(new Item("nuts", 1, 4));
            items.Add(new Item("ham", 2, 3));
            items.Add(new Item("whiskey", 8, 13));

            Console.WriteLine("Items: ");
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }

            int BagCapacity = 10;

            KnapSackProblem problem = new KnapSackProblem();

            int totalValueOfItems = 0;
            List<Item> itemsToBePacked = problem.FindItemsToPack(items, BagCapacity, out totalValueOfItems);

            var finalCost = 0;
            var finalWeigth = 0;
            var finalItems = new List<string>();
            foreach (var item in itemsToBePacked)
            {
                finalItems.Add(item.Name);
                finalCost += item.Price;
                finalWeigth += item.Weigth;
            }

            Console.WriteLine("\nAfter solving the KnapSack problem: ");
            Console.WriteLine(string.Join(" + ", finalItems));
            Console.WriteLine("weight = {0}", finalWeigth);
            Console.WriteLine("cost = {0}", finalCost);
        }
    }
}
