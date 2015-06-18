//### Problem 4. Hexadecimal to decimal
//*	Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Text;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Please insert a binary number... Number = ");
        string number = Console.ReadLine();

        int decimalNumber = HexadecimalToDecimalConverter(number);
        Console.WriteLine("The decimal rapresentation of {0} is {1}", number, decimalNumber);
    }

    private static int HexadecimalToDecimalConverter(string hex)
    {
        int decimalNumber = 0;
        int exp = 1;
        string newHex= null;
        for (int i = 0; i < hex.Length; i++)
        {
            newHex = newHex + hex.Substring(hex.Length - 1 - i, 1);
        }

        for (int i = 0; i < hex.Length; i++)
        {
            exp = exp*16;
            if (i == 0)
            {
                exp = 1;
            }
            //byte subs = byte.Parse(newHex.Substring(i, 1));

            byte subs = 0;
            string substr = newHex.Substring(i, 1);

            switch (substr)
	        {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9": subs = byte.Parse(substr); break;
                case "A": subs =10; break;
                case "B": subs =11; break;
                case "C": subs =12; break;
                case "D": subs =13; break;
                case "E": subs =14; break;
                case "F": subs =15; break;
                default: Console.WriteLine("Invalid input!"); break;
	        }

            decimalNumber += exp * subs;
        }
        return decimalNumber;
    }
}

