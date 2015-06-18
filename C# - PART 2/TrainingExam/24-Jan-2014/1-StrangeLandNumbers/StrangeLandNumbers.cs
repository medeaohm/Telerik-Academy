using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StrangeLandNumbers
{
    
    static void Main()
    {
        string input = Console.ReadLine();
        //string input = "pNWEoBJECbINf";

        var strangeNumber = StrangeNumber(input);

        long decimalNumber = ConverToDecimal(strangeNumber);
        Console.WriteLine(decimalNumber); 
    }

    private static long ConverToDecimal(List<int> strangeNumber)
    {
        strangeNumber.Reverse();
        long exp = 1;
        long number = strangeNumber[0];
        for (int i = 1; i < strangeNumber.Count; i++)
        {
            exp *= 7;
            number += exp * strangeNumber[i];
        }
        return number;
    }

    private static List<int> StrangeNumber(string input)
    {
        var strange = new List<int>();
        while (input.Length > 0)
        {
            if (input.StartsWith("f"))
            {
                strange.Add(0);
                input = input.Substring(1);
            }
            else if (input.StartsWith("bIN"))
            {
                strange.Add(1);
                input = input.Substring(3);
            }
            else if (input.StartsWith("oBJEC"))
            {
                strange.Add(2);
                input = input.Substring(5);
            }
            else if (input.StartsWith("mNTRAVL"))
            {
                strange.Add(3);
                input = input.Substring(7);
            }
            else if (input.StartsWith("lPVKNQ"))
            {
                strange.Add(4);
                input = input.Substring(6);
            }
            else if (input.StartsWith("pNWE"))
            {
                strange.Add(5);
                input = input.Substring(4);
            }
            else if (input.StartsWith("hT"))
            {
                strange.Add(6);
                input = input.Substring(2);
            } 
        }
        return strange;
    }
}
