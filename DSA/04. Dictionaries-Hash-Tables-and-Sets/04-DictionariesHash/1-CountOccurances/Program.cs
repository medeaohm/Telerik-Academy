//1. Write a program that counts in a given array of `double` values the number of occurrences of each value.Use `Dictionary<TKey, TValue>`.   
//    >Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
//    >-2.5 -> 2 times
//    >3 -> 4 times  
//    >4 -> 3 times

namespace CountOccurances
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            double[] array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            Dictionary<double, int> output = CountOccurances(array);

            foreach (var pair in output)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }

        private static Dictionary<double, int> CountOccurances(double[] array)
        {
            var occurances = new Dictionary<double, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!occurances.ContainsKey(array[i]))
                {
                    occurances.Add(array[i], 1);
                }
                else
                {
                    occurances[array[i]]++;
                }
            }

            return occurances;
        }
    }
}
