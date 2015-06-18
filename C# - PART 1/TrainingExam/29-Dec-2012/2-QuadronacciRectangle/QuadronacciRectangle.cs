using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class QuadronacciRectangle
{
    static void Main()
    {
        BigInteger tN_1 = long.Parse(Console.ReadLine());
        BigInteger tN_2 = long.Parse(Console.ReadLine());
        BigInteger tN_3 = long.Parse(Console.ReadLine());
        BigInteger tN_4 = long.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int n = c * r;
        BigInteger[] col = new BigInteger[n];

        BigInteger t_n = tN_1 + tN_2 + tN_3 + tN_4;

        col[0] = tN_1;
        col[1] = tN_2;
        col[2] = tN_3;
        col[3] = tN_4;
        col[4] = t_n;

            for (int i = 5; i < n; i++)
            {
                tN_1 = tN_2;
                tN_2 = tN_3;
                tN_3 = tN_4;
                tN_4 = t_n;
                t_n = tN_1 + tN_2 + tN_3 + tN_4;
                col[i] = t_n;
            }
        
       BigInteger[,] matrix = new BigInteger[n,n];

       int a = 0;
       int b = c;
        for (int i = 0; i < r; i++)
        {
            Console.WriteLine("");
            for (int j = a; j < b; j++)
            {
                matrix[i, j] = col[j];
                Console.Write(matrix[i,j] + " ");
            }
            a = a + c;
            b = b + c;
        }
    }
}

