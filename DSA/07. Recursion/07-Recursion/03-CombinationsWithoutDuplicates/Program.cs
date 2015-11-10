// 3. Modify the previous program to `skip duplicates`:
//  * `n=4, k=2` &rarr; `(1 2), (1 3), (1 4), (2 3), (2 4), (3 4)`

namespace _03_CombinationsWithoutDuplicates
{
    using System;

    public class Program
    {
        private const int K = 2;
        private const int N = 4;

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
                Combinations(index + 1, i + 1);
            }
        }

        private static void Print()
        {
            Console.WriteLine("({0})", string.Join(", ", array));
        }
    }
}
