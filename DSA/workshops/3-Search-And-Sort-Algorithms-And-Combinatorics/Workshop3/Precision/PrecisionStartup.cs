namespace Precision
{
    using System;

    public class PrecisionStartup
    {
        public static void Main()
        {
            int maxDenominator = int.Parse(Console.ReadLine());
            var fraction = Console.ReadLine().Split('.')[1];

            int bestNom = 0;
            int bestDen = 1;
            int bestPrecision = 0;
            for (int den = 1; den <= maxDenominator; den++)
            {
                int left = 0;
                int right = den;

                while (left < right)
                {
                    int middle = (left + right) / 2;
                    if (Compare(fraction, middle, den))
                    {
                        right = middle;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

                int currentPrecision = Precision(fraction, left - 1, den);
                if (currentPrecision > bestPrecision)
                {
                    bestDen = den;
                    bestNom = left - 1;
                    bestPrecision = currentPrecision;
                }

                currentPrecision = Precision(fraction, left, den);
                if (currentPrecision > bestPrecision)
                {
                    bestDen = den;
                    bestNom = left;
                    bestPrecision = currentPrecision;
                }
            }

            Console.WriteLine("{0}/{1}", bestNom, bestDen);
            Console.WriteLine(bestPrecision + 1);  
        }

        static int Precision(string fraction, int a, int b)
        {
            a *= 10;
            int i;

            for (i = 0; i < fraction.Length; i++)
            {             
                int digit = a / b;
                if (digit != fraction[i] - '0')
                {
                    break;
                }
                a = a % b * 10;
            }
            return i;
        }

        static bool Compare(string fraction, int a, int b)
        {
            a *= 10;
            int i;

            for (i = 0; i < fraction.Length; i++)
            {
                int digit = a / b;
                if (digit < fraction[i] - '0')
                {
                    return false;
                }
                else if (digit > fraction[i] - '0')
                {
                    return true;
                }
                a = a % b * 10;
            }
            return true;
        }
    }
}
