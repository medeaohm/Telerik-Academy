//2. Write a program to calculate the "**Minimum Edit Distance**" (MED) between two words. `MED(x, y)` is the minimal sum of costs of edit operations used to transform `x` to `y`.
//  * _Sample costs_:
//      * cost(replace a letter) = 1
//      * cost(delete a letter) = 0.9
//      * cost(insert a letter) = 0.8
//  * _Example_:
//      * x = "developer", y = "enveloped" & rarr; cost = 2.7 
//      * delete ‘d’:  "developer" &rarr; "eveloper", cost = 0.9
//      * insert ‘n’:  "eveloper" &rarr; "enveloper", cost = 0.8
//      * replace ‘r’ &rarr; ‘d’:  "enveloper" &rarr; "enveloped", cost = 1

namespace MinimumEditDistance
{
    using System;

    public class StartUp
    {
        private const double Cost_Delete = 0.9;
        private const double Cost_Insert = 0.8;
        private const double Cost_Replace = 1;

        public static void Main()
        {
            string string1 = "developer";
            string string2 = "enveloped";

            Console.WriteLine("{0} -> {1} = {2}", string1, string2, MinimumDistance(string1, string2));
        }

        private static double MinimumDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            double[,] d = new double[n + 1, m + 1];

            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            for (int i = 0; i <= n; i++)
            {
                d[i, 0] = i;
            }

            for (int j = 0; j <= m; j++)
            {
                d[0, j] = j;
            }


            for (int j = 1; j <= m; j++)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (s[i - 1] == t[j - 1])
                    {
                        d[i, j] = d[i - 1, j - 1];  //no operation
                    }
                    else
                    {
                        d[i, j] = GetMin(
                            d[i - 1, j] + Cost_Delete,          //a deletion
                            d[i, j - 1] + Cost_Insert,          //an insertion
                            d[i - 1, j - 1] + Cost_Replace);    //a substitution
                    }
                }
            }
            return d[n, m];
        }

        private static double GetMin(double a, double b, double c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
