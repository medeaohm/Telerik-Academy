using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;



class KaspichanNumbers
{
    static void Main()
    {
        BigInteger input = BigInteger.Parse(Console.ReadLine());
        string[] table = CreateTable();
        string kaspician = ConvertToKaspichanNumber(table, input);
        Console.WriteLine(kaspician);
    }

    private static string ConvertToKaspichanNumber(string[] table, BigInteger input)
    {
        var kasp = new StringBuilder();
        var inp = new List<int>();
        BigInteger rem = input % 256;
        if (input == 0)
        {
            kasp.Append("A");
        }
        while (input > 0)
        {
            inp.Add((int)rem);
            //kasp.Append(table[(int)rem]);
            input /= 256;
            rem = input % 256; 
        }
        inp.Reverse();
        foreach (int number in inp)
        {
            kasp.Append(table[number]);
        }
        return kasp.ToString();
    }

    private static string[] CreateTable()
    {
        string[] table = new string[256];

        int index = 0;
        while (index < 256)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (index == 256)
                    {
                        break;
                    }
                    if (i == 0)
                    {
                        table[index] = ((char)(65 + j)).ToString();
                    }
                    if (i > 0)
                    {
                        table[index] = ((char)(96 + i)).ToString() + ((char)(65 + j)).ToString();
                    }
                    index++;
                }
            }
        }
        return table;
    }
}

