using System;
using System.Numerics;


    class Tribonacci
    {
        static void Main()
        {
            BigInteger tN_1 = long.Parse(Console.ReadLine());
            BigInteger tN_2 = long.Parse(Console.ReadLine());
            BigInteger tN_3 = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            BigInteger t_n = tN_1 + tN_2 + tN_3;

            if (n == 3)
            {
                t_n = tN_3;
            }
            else if (n == 2)
            {
                t_n = tN_2;
            }
            else if (n == 1)
            {
                t_n = tN_1;
            }
            else
            {
                for (int i = 4; i < n; i++)
                {
                    tN_1 = tN_2;
                    tN_2 = tN_3;
                    tN_3 = t_n;
                    t_n = tN_1 + tN_2 + tN_3;
                }
            }
            Console.WriteLine(t_n);
        }
    }

