namespace _01_BinaryPasswords
{
    using System;
    using System.Numerics;

    public class BinaryPasswords
    {
        private const int K = 2;

        public static void Main()
        {
            string input = Console.ReadLine();
            int numberOfStars = 0;

            foreach (var letter in input)
            {
                if (letter == '*')
                {
                    numberOfStars++;
                }
            }

            BigInteger result;
            if (input.Length < 1)
            {
                result = 0;
            }
            else if (numberOfStars == 0)
            {
                result = 1;
            }
            else
            {
                result = PowerOfTwo(numberOfStars);
            }

            Console.WriteLine(result);
        }

        private static BigInteger PowerOfTwo(int power)
        {
            BigInteger result = 2;
            for (int x = 1; x < power; x++)
            {
                result *= 2;
            }

            return result;
        }
    }
}
