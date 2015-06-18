using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GreedyDwarf
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] val = input.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        int[] valley = new int[val.Length];

        for (int i = 0; i < val.Length; i++)
        {
            valley[i] = int.Parse(val[i]);
        }


        int m = int.Parse(Console.ReadLine());
        long maxCoins = long.MinValue;
        for (int i = 0; i < m; i++)
        {
            string path = Console.ReadLine();
            long coins = CalculateCoins(path, valley);
            if (coins > maxCoins)
            {
                maxCoins = coins;
            }
        }
        Console.WriteLine(maxCoins);
    }

    private static long CalculateCoins(string input, int[] valley)
    {
        long coins = 0;
        string[] pathS = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        //int[] path = new int[pathS.Length];

        int[] path = pathS.Select(ns => int.Parse(ns)).ToArray();
        //for (int i = 0; i < pathS.Length; i++)
        //{
        //    path[i] = int.Parse(pathS[i].Trim());
        //}

        bool[] visited = new bool[valley.Length];
        int pos = 0;
        int step = -1;

        while (true)
        {
            if (pos < 0)
            {
                break;
            }
            else if (pos >= valley.Length)
            {
                break;
            }
            else if (visited[pos])
            {
                break;
            }

            visited[pos] = true;
            coins += valley[pos];
            step++;
            if (step > path.Length - 1)
            {
                step = path.Length % step;
            }
            pos += path[step % path.Length];
  
        }
        return coins;
    }
}

