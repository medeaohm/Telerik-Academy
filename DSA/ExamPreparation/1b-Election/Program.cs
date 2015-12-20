namespace Election
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            

            int[] seatsPerParty = new int[n];
            for (int i = 0; i < n; i++)
            {
                seatsPerParty[i] = int.Parse(Console.ReadLine());
            }

            BigInteger result = Solve(seatsPerParty, k);
            
            Console.WriteLine(result);
        }

        private static BigInteger Solve(int[] parties, int k)
        {
            var sums = new BigInteger[parties.Sum() + 1];
            sums[0] = 1;
            var maxSum = 0;

            for (int i = 0; i < parties.Length; i++)
            {
                var num = parties[i];
                for (int j =maxSum; j >= 0; j--)
                {
                    if (sums[j] > 0)
                    {
                        sums[j + num] += sums[j];
                        maxSum = Math.Max(j + num, maxSum);
                    }
                }
            }

            BigInteger combinations = 0;
            for (int i = k; i <= parties.Sum(); i++)
            {
                combinations += sums[i];
            }

            return combinations;
        }
    }
}

//    public class Program
//    {
//        public static void Main()
//        {
//            int k = int.Parse(Console.ReadLine());
//            int n = int.Parse(Console.ReadLine());
//            int count = 0;

//            int[] seatsPerParty = new int[n];
//            for (int i = 0; i < n; i++)
//            {
//                seatsPerParty[i] = int.Parse(Console.ReadLine());
//            }

//            for (int i = 1; i < Math.Pow(2, n); i++)
//            {
//                if (k <= CalculateSum(i, seatsPerParty))
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine(count);
//        }
//        static long CalculateSum(int subSet, int[] number)
//        {
//            long sum = 0;
//            for (int i = 0; i < number.Length; i++)
//            {
//                int bit = (subSet & (1 << i)) >> i;
//                sum += number[i] * bit;
//            }
//            return sum;
//        }
//    }
//}
