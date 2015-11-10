// 6. Write a program for generating and printing `all subsets of k strings` from given set of strings.
//  * _Example_: `s = {test, rock, fun}, k=2` &rarr; `(test rock),  (test fun),  (rock fun)`

namespace _06_AllSubsetsOfKStrings
{
    using System;

    public class Program
    {
        private static string[] subset;

        private const int K = 2;

        private static void Main()
        {
            string [] set = new string[] { "test", "rock", "fun" };
            subset = new string[K];

            GetKElementSubset(0, 0, K, set);
        }

        private static void GetKElementSubset(int index, int start, int end, string[] set)
        {
            if (index == K)
            {
                Print();
                return;
            }

            for (int i = start; i < set.Length; i++)
            {
                subset[index] = set[i];
                GetKElementSubset(index + 1, i + 1, end, set);
            }
        }

        private static void Print()
        {
            Console.WriteLine("[{0}]", string.Join(", ", subset));
        }
    }
}
