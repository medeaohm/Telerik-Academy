namespace _03_SumsOfSubsets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static int[] subset;
        private static List<int> allSums;
        private static int sum;

        public static void Main()
        {
            int numberOfIteration = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfIteration; i++)
            {
                sum = 0;
                allSums = new List<int>();

                var nAndK = Console.ReadLine().Split(' ');
                int setSize = int.Parse(nAndK[0]);
                int subSetsSize = int.Parse(nAndK[1]);
                subset = new int[subSetsSize];

                var set = Console.ReadLine().Split(' ');

                CalculateSumOfAllSubsets(sum, 0, 0, subSetsSize, setSize, subSetsSize, set);

                for (int j = 0; j < allSums.Count; j++)
                {
                    Console.WriteLine(allSums[j]);
                }

                Console.WriteLine(allSums.Sum());
            }
        }

        private static void CalculateSumOfAllSubsets(int sum, int index, int start, int end, int setSize, int subSetsSize, string[] set)
        {
            if (index == subSetsSize)
            {
                for (int i = 0; i < subset.Length; i++)
                {                   
                    sum += subset[i];
                }
                allSums.Add(sum);
                Console.WriteLine("{0} - {1} ", string.Join(" ", subset), sum);
                return;
            }

            for (int i = start; i < setSize; i++)
            {
                subset[index] = int.Parse(set[i]);
                CalculateSumOfAllSubsets(sum, index + 1, i+1, end, setSize, subSetsSize, set);
            }
        }
    }
}

/*
2
4 2
1 2 3 4
5 3
1 –5 7 10 –3


    */
