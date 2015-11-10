//1. Write a recursive program that simulates the execution of `n nested loops `from 1 to n.

//           1 1
//  n= 2->   1 2
//           2 1
//           2 2
  
//           1 1 1
//           1 1 2
//           1 1 3
//           1 2 1
//  n= 3->  ...
//           3 2 3
//           3 3 1
//           3 3 2
//           3 3 3

namespace _01_NestedLoops
{
    using System;

    public class NestedLoops
    {
        private static readonly int[] result = new int[N];
        private const int N = 3;

        public static void Main()
        {
            SimulateNestedLoops(0, N);
        }

        private static void SimulateNestedLoops(int startValue, int endValue, int depth = 0)
        {
            if (depth == N)
            {
                Print(result);
                return;
            }

            for (int i = startValue + 1; i <= endValue; i++)
            {
                result[depth] = i;
                SimulateNestedLoops(0, endValue, depth + 1);
            }
        }

        private static void Print(int[] result)
        {
            Console.WriteLine(string.Join(" ", result));
        }
    }
}