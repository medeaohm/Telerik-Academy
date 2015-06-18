using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Tower
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int w = 2 * h;
        string dot = ".";
        string s1 = "/";
        string s2 = "\\";
        string minus = "-";
        int c = 0;
        int step = 1;

        int a = (w / 2) ;
        int b = (w / 2) - 1;

        for (int j = 0; j < h; j++)
        {
            a--;
            b++;
            Console.WriteLine("");
            for (int i = 0; i < w; i++)
            {
                if (i < a | i > b)
                {
                    Console.Write(dot);
                }
                else if (i == a)
                {
                    Console.Write(s1);
                }
                else if (i == b)
                {
                    Console.Write(s2);
                }
                else if (i > a & i < b  & j == c)
                {
                    Console.Write(minus);
                }
                else
                {
                    Console.Write(dot);
                }
            }
            if (j == 0)
            {
                c = 1;
            }
            if (j == c)
            {
               step++;
               c = c + step; 
            }
        }
    }
}

