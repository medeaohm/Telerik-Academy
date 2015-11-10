// 11. * Write a program to generate all `permutations with repetitions `of given multi-set.
//   * _Example_: the multi-set `{1, 3, 5, 5}` has the following 12 unique permutations:

//    { 1, 3, 5, 5 }	{ 1, 5, 3, 5 }
//    { 1, 5, 5, 3 }	{ 3, 1, 5, 5 }
//    { 3, 5, 1, 5 }	{ 3, 5, 5, 1 }
//    { 5, 1, 3, 5 }	{ 5, 1, 5, 3 }
//    { 5, 3, 1, 5 }	{ 5, 3, 5, 1 }
//    { 5, 5, 1, 3 }	{ 5, 5, 3, 1 }

  //* Ensure your program efficiently avoids duplicated permutations.
  //* Test it with `{
  //  1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }`.

namespace _11.RecursionRep
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {

            //int[] set = new int[] { 1, 3, 5, 5 };
            int[] set = new int[] { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };


            Array.Sort(set);
            
            PermuteRep(set, 0, set.Length);
        }

        private static void PermuteRep(int[] set, int start, int length)
        {
            Console.WriteLine("({0})", string.Join(" ", set));

            if (start < length)
            {
                for (int i = length - 2; i >= start; i--)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (set[i] != set[j])
                        {
                            Swap(ref set[i], ref set[j]);
                            PermuteRep(set, i + 1, length);
                        }
                    }

                    var tmp = set[i];
                    for (int k = i; k < length - 1;)
                    {
                        set[k] = set[++k];
                    }

                    set[length - 1] = tmp;
                }
            }
        }

        private static void Swap(ref int v1, ref int v2)
        {
            var temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
