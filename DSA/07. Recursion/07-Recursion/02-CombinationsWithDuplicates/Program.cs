﻿// 2. Write a recursive program for generating and printing all the `combinations with duplicates `of k elements from n-element set.
//    Example: n= 3, k= 2 -> (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)

namespace _02_CombinationsWithDuplicates
{
    using System;

    public class Program
    {
        private const int K = 2;
        private const int N = 3;

        private static int[] array;

        public static void Main()
        {
            array = new int[K];

            Combinations(0, 1);
        }

        private static void Combinations(int index, int start)
        {
            if (index >= K)
            {
                Print();
                return;
            }

            for (int i = start; i <= N; i++)
            {
                array[index] = i;
                Combinations(index + 1, i);
            }
        }

        private static void Print()
        {
            Console.WriteLine("({0})", string.Join(", ", array));
        }
    }
}
