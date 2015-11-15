namespace BinaryTree
{
    using System;
    using System.Numerics;

    public class BinaryTreeStartup
    {
        static long[] memo;
        public static void Main()
        {
            string input = Console.ReadLine();

            var groups = new int[26];

            foreach (var ball in input)
            {
                groups[ball - 'A']++;
            }

            int numberOfBalls = input.Length;

            memo = new long[numberOfBalls + 1];
            var factorials = new long[numberOfBalls + 1];
            factorials[0] = 1;
            for (int i = 0; i < numberOfBalls; i++)
            {
                factorials[i + 1] = factorials[i] * (i + 1);
            }

            long result = factorials[numberOfBalls];
            foreach (var item in groups)
            {
                result /= factorials[item];
            }

            BigInteger numberOfColouredTrees = result;
            numberOfColouredTrees *= NumberOfTrees(numberOfBalls);
            Console.WriteLine(numberOfColouredTrees);
        }

        static long NumberOfTrees(int numberOfBalls)
        {
            if (numberOfBalls == 0)
            {
                return 1;
            }

            if (memo[numberOfBalls] > 0)
            {
                return memo[numberOfBalls];
            }

            long result = 0;
            for (int i = 0; i < numberOfBalls; i++)
            {
                result += NumberOfTrees(i) * NumberOfTrees(numberOfBalls - 1 - i);
            }

            memo[numberOfBalls] = result;
            return result;
        }
    }
}

