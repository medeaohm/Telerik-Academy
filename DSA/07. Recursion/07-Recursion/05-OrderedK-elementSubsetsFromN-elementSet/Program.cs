//5. Write a recursive program for generating and printing all ordered k-element subsets from n-element set
//  * _Example_: `n=3, k=2, set = {hi, a, b}` => `(hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)`

namespace _05_OrderedK_elementSubsetsFromN_elementSet
{
    using System;

    public class Program
    {
        private static string[] subset;
        private static string[] set;

        private const int N = 3;
        private const int K = 2;

        private static void Main()
        {
            set = new string[N] {"hi", "a", "b" };
            subset = new string[K];

            GetKElementSubset(0);
        }

        private static void GetKElementSubset(int startIndex)
        {
            if (startIndex == K)
            {
                Print();
                return;
            }

            for (int i = 0; i < N; i++)
            {
                subset[startIndex] = set[i];
                GetKElementSubset(startIndex + 1);
            }
        }

        private static void Print()
        {
            Console.WriteLine("[{0}]", string.Join(", ", subset));
        }
    }
}
