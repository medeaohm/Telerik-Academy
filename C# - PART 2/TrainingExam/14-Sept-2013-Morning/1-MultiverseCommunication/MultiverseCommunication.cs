using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MultiverseCommunication
{
    static void Main()
    {
        string input = Console.ReadLine();
        input.Trim();
        var inp = new List<int>();

        while (true)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            else if (input.StartsWith("CHU"))
            {
                inp.Add(0);
            }
            else if (input.StartsWith("TEL"))
            {
                inp.Add(1);
            }
            else if (input.StartsWith("OFT"))
            {
                inp.Add(2);
            }
            else if (input.StartsWith("IVA"))
            {
                inp.Add(3);
            }
            else if (input.StartsWith("EMY"))
            {
                inp.Add(4);
            }
            else if (input.StartsWith("VNB"))
            {
                inp.Add(5);
            }
            else if (input.StartsWith("POQ"))
            {
                inp.Add(6);
            }
            else if (input.StartsWith("ERI"))
            {
                inp.Add(7);
            }
            else if (input.StartsWith("CAD"))
            {
                inp.Add(8);
            }
            else if (input.StartsWith("K-A"))
            {
                inp.Add(9);
            }
            else if (input.StartsWith("IIA"))
            {
                inp.Add(10);
            }
            else if (input.StartsWith("YLO"))
            {
                inp.Add(11);
            }
            else if (input.StartsWith("PLA"))
            {
                inp.Add(12);
            }
            input = input.Substring(3);
        }
        inp.Reverse();
        double decimalNumber = ConvertToDecimal(inp);
        Console.WriteLine(decimalNumber);
    }

    private static double ConvertToDecimal(List<int> input)
    {
        double decimalNumber = input[0];
        for (int i = 1; i < input.Count; i++)
        {
            decimalNumber += Math.Pow(13, i) * input[i];
        }
        return decimalNumber;
    }
}

