using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class TRES4Numbers
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        string output = DecimalToTresConverter(input);
        Console.WriteLine(output);

    }

    private static string DecimalToTresConverter(ulong number)
    {
        var tres = new StringBuilder();
        var tresNumber = new List<string>();
        if (number == 0)
        {
            tres.Append("LON+");
        }

        while (number != 0)
        {
            byte remainder = (byte)(number % 9);
            string rem = null;
            switch (remainder)
            {
                case 0: rem = "LON+"; break;
                case 1: rem = "VK-"; break;
                case 2: rem = "*ACAD"; break;
                case 3: rem = "^MIM"; break;
                case 4: rem = "ERIK|"; break;
                case 5: rem = "SEY&"; break;
                case 6: rem = "EMY>>"; break;
                case 7: rem = "/TEL"; break;
                case 8: rem = "<<DON"; break;
                default: break;
            }
            tresNumber.Add(rem);
            //tresNumber.Reverse();
            //tres.Append(rem);
            number /= 9;
        }
        for (int i = tresNumber.Count - 1; i >= 0; i--)
        {
            tres.Append(tresNumber[i]);
        }

        return tres.ToString();
    }
}


