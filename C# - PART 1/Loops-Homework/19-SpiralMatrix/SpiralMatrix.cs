//### Problem 19.** Spiral Matrix
//*	Write a program that reads from the console a positive integer number `n` (1 = n = 20) and prints a matrix holding the numbers from `1` to `n*n` in the form of square spiral like in the examples below.

//_Examples:_

//    n = 2	matrix		n = 3	matrix		n = 4	matrix
//            1 2				1 2 3				1  2  3  4
//            4 3				8 9 4				12 13 14 5
//                              7 6 5				11 16 15 6
//                                                  10 9  8  7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class SpiralMatrix
    {
        public static int lev;
        int lev_lim, count, bk, cd, low, l, m;
        SpiralMatrix()
        {
            lev = lev_lim = count = bk = cd = low = l = m = 0;
        }

        void level(int n1, int r, int c)
        {
            lev_lim = n1 % 2 == 0 ? n1 / 2 : (n1 + 1) / 2;
            if ((r <= lev_lim) && (c <= lev_lim))
                lev = Math.Min(r, c);
            else
            {
                bk = r > c ? (n1 + 1) - r : (n1 + 1) - c;
                low = Math.Min(r, c);
                if (low <= lev_lim)
                    cd = low;
                lev = cd < bk ? cd : bk;
            }
        }

        int func(int n2, int xo, int lo)
        {
            l = xo;
            m = lo;
            count = 0;
            level(n2, l, m);

            for (int ak = 1; ak < lev; ak++)
                count += 4 * (n2 - 1 - 2 * (ak - 1));
            return count;
        }

        public static void Main(string[] args)
        {
            int i, j, av, num = 0;
            SpiralMatrix ob = new SpiralMatrix();
            Console.WriteLine("Enter Order..");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The Matrix of {0} x {1} Order is=>\n", n, n);
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    av = ob.func(n, i, j);

                    if ((j >= i) && (i == lev))
                    {
                        num = (j - i) + 1;
                    }

                    if ((j == ((n + 1) - lev) && (i > lev) && (i <= j)))
                    {
                        num = (n - 2 * (lev - 1) + (i - 1) - (n - j));
                    }

                    if ((i == ((n + 1) - lev) && (j < i)))
                    {
                        num = ((n - 2 * (lev - 1)) + ((n - 2 * (lev - 1)) - 1) + (i - j));
                    }

                    if ((j == lev) && (i > lev) && (i < ((n + 1) - lev)))
                    {
                        num = ((n - 2 * (lev - 1)) + ((n - 2 * (lev - 1)) - 1) + ((n - 2 * (lev - 1)) - 1) + (((n + 1) - lev) - i));
                    }

                    av += num;
                    Console.Write("{0,3:D} ", av);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

 


