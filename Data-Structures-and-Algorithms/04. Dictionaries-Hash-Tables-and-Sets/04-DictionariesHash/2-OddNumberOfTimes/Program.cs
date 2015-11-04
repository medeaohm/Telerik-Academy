//2. Write a program that extracts from a given sequence of strings all elements that present in it odd number of times.Example:

//    > {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}

namespace OddNumberOfTimes
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] array = {"C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            Dictionary<string, int> occurances = CountOccurances(array);
            List<string> oddOccurances = SelectOddOccurances(occurances);

            Console.WriteLine("{" + string.Join(", ", array) + "} -> {" + string.Join(", ", oddOccurances) + "}");

        }

        private static Dictionary<string, int> CountOccurances(string[] array)
        {
            var occurances = new Dictionary<string, int>();

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

        private static List<string> SelectOddOccurances(Dictionary<string, int> occurances)
        {
            var oddOccurances = new List<string>();

            foreach (var item in occurances)
            {
                if ((item.Value % 2) != 0)
                {
                    oddOccurances.Add(item.Key);
                }
            }

            return oddOccurances;
        }
    }
}
