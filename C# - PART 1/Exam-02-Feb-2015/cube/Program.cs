using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
                int n = int.Parse(Console.ReadLine());
        string col = ":";
        string vl = "|";
        string minus = "-";
        int a0 = 1;
        int b0 = 1;
        int a = n;
        int b = n;
        int c = n;
        int d0 = 2;
        int d = n ;
        int e0 =3;
        int e = n+1;
        for (int i = 0; i < 2 * n - 1; i++)
        {
           
            Console.WriteLine("");
            for (int j = 0; j < 2 * n -1 ; j++)
            {
               
                if (i < n & j < n)
                {
                    if (i == 0)
                    {
                        Console.Write(col);
                    }
                    else if (i == n - 1)
                    {
                        Console.Write(col);
                    }
                    else if (j == 0)
                    {
                        Console.Write(col);
                    }
                    else if (j < n - 1 & j > 0)
                    {
                        Console.Write(" ");
                    }
                    else if (j == n - 1)
                    {
                        Console.Write(col);
                    }
                }
                else if (i < n & j >= n)
                {
                    if (i == a0 & j == a)
                    {
                        Console.Write(col);
                        a++;
                        a0++;
                    }
                    else if (i > a0 - 1 & j < a)
                    {
                        Console.Write(vl);

                    }
                }
                else if (i >= n & j < n)
                {
                 
                    if (i == b & j == b0)
                    {
                        Console.Write(col);
                        b++;
                        b0++;
                    }
                    else if (i > b -2 & j > b0 -1)
                    {
                        Console.Write(minus);
                    }
                    else
                    {
                        Console.Write(" ");

                    }
                }

                else if (i >= n & j >= n)
                {
                    if (j == 2*n -2)
                    {
                        Console.Write(col);
                    }
                    else if (i == 2 * n - 2 & (j < (2* n) -2))
                    {
                        Console.Write(col);
                    }
                    else  if (j == c & i == c)
                    {
                        Console.Write(col);
                        c++;
                    }
                    else if(i > c -2 & j > c -1 & j < 2*n-2)
                    {
                        Console.Write(vl);
                    }
                     else
                     {
                         Console.Write(minus);
                     }
                }

            }
     
        }
        }
    }

