// 4. Write a recursive program for generating and printing all `permutations` of the numbers 1, 2, ..., n for given integer number n.Example:
//  * `n= 3` &rarr; `{1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}`

namespace _04_PermutationsForGivenN
{
    using System;

    public class Program
    {
        private const int N = 3;

        private static int[] array;

        public static void Main()
        {
            array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = i + 1;
            }

            Permutations(0);
        }

        private static void Permutations(int start)
        {
            if (start >= N)
            {
                Print();
                return;
            }

            for (int i = start; i < N; i++)
            {
                Swap(start, i);
                Permutations(start + 1);
                Swap(start, i);
            }
        }

        private static void Swap(int firstIndex, int secondIndex)
        {
            int storedValue = array[secondIndex];
            array[secondIndex] = array[firstIndex];
            array[firstIndex] = storedValue;
        }

        private static void Print()
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}
