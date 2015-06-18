using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Zerg
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> zerg = ZergToNumber(input);

        long decNumber = ConvertToDecimal(zerg);
        Console.WriteLine(decNumber);
    }

    private static long ConvertToDecimal(List<string> zerg)
    {
        zerg.Reverse();
        long number = 0;
        for (int i = 0; i < zerg.Count; i++)
        {
            number += int.Parse(zerg[i]) * (long)Math.Pow(15, i);
        }
        return number;
    }

    private static List<string> ZergToNumber(string input)
    {
        List<string> zerg = new List <string>();
        string z = input;
        while (z.Length > 1)
        {
            if (z.StartsWith("Rawr"))
            {
                zerg.Add("0");
            }
            else if (z.StartsWith("Rrrr"))
            {
                zerg.Add("1");
            }
            else if (z.StartsWith("Hsst"))
            {
                zerg.Add("2");
            }
            else if (z.StartsWith("Ssst"))
            {
                zerg.Add("3");
            }
            else if (z.StartsWith("Grrr"))
            {
                zerg.Add("4");
            }
            else if (z.StartsWith("Rarr"))
            {
                zerg.Add("5");
            }
            else if (z.StartsWith("Mrrr"))
            {
                zerg.Add("6");
            }
            else if (z.StartsWith("Psst"))
            {
                zerg.Add("7");
            }
            else if (z.StartsWith("Uaah"))
            {
                zerg.Add("8");
            }
            else if (z.StartsWith("Uaha"))
            {
                zerg.Add("9");
            }
            else if (z.StartsWith("Zzzz"))
            {
                zerg.Add("10");
            }
            else if (z.StartsWith("Bauu"))
            {
                zerg.Add("11");
            }
            else if (z.StartsWith("Djav"))
            {
                zerg.Add("12");
            }
            else if (z.StartsWith("Myau"))
            {
                zerg.Add("13");
            }
            else if (z.StartsWith("Gruh"))
            {
                zerg.Add("14");
            }
            z = z.Substring(4); 
        }
        return zerg;
    }
}
