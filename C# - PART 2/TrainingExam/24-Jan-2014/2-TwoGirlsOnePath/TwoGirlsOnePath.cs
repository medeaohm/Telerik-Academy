using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;



class TwoGirlsOnePath
{
    static void Main()
    {
        var path = new List<long>();
        string pathStr = Console.ReadLine();
        
        string[] pathStrSplit = pathStr.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        foreach (string item in pathStrSplit)
        {
            path.Add(long.Parse(item));
        }
        
        BigInteger floMT = 0;
        BigInteger floDT = 0;


        long i = 0;
        long j = path.Count() - 1;
        bool draw = false;
        bool molly = true;
        bool dolly = true;

            do
            {
                if (path[(int)i] == 0 && path[(int)j] == 0)
                {
                    draw = true;
                    break;
                }
                else if (path[(int)i] == 0)
                {
                    floDT += path[(int)j];
                    molly = false;
                    break;
                }
                else if (path[(int)j] == 0)
                {
                    dolly = false;
                    floMT += path[(int)i];
                    break;
                }
                else if (i == j)
                {
                    if (i < 2 & j < 2)
                    {
                        path[(int)i] = 0;
                        floMT += 0;
                        floDT += 0;
                    }
                    else
                    {
                        long stepM = path[(int)i];
                        long stepD = path[(int)j];
                        floMT += path[(int)i] / 2;
                        floDT += path[(int)i] / 2;
                        path[(int)i] = path[(int)i] % 2;
                        i = i + stepM;
                        j = j - stepD + 1;
                        if (i > path.Count() - 1)
                        {
                            i = i - path.Count();
                        }
                        if (j < 0)
                        {
                            j = path.Count() + j;
                        }
                    }
                }
                else
                {
                    long stepM = path[(int)i];
                    long stepD = path[(int)j];
                    floMT += path[(int)i];
                    path[(int)i] = 0;
                    floDT += path[(int)j];
                    path[(int)j] = 0;
                    i = i + stepM;
                    j = j - stepD;
                    while (i > path.Count() - 1)
                    {
                        i %= path.Count();
                    }
                    while (j < 0)
                    {
                        j = path.Count() + (j % path.Count());
                        if (j == path.Count())
                        {
                            j = 0;
                        }
                    }
                }
                
            }
            while (true);

        if (draw)
        {
            Console.WriteLine("Draw");
            Console.WriteLine("{0} {1}", floMT, floDT);
        }
        else if (floMT == floDT)
        {
            Console.WriteLine("Draw");
            Console.WriteLine("{0} {1}", floMT, floDT);
        }
        else if (molly)
        {
            Console.WriteLine("Molly");
            Console.WriteLine("{0} {1}", floMT, floDT);
        }
        else if (dolly)
        {
            Console.WriteLine("Dolly");
            Console.WriteLine("{0} {1}", floMT, floDT);
        }
    }
}