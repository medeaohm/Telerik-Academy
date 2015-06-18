//### Problem 6. binary to hexadecimal
//*	Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Please insert a binary number... Number = ");
        string number = Console.ReadLine();

        if (number.Length == 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            string binaryNumber = BinaryToHexadecimalConverter(number);
            Console.WriteLine("The binary rapresentation of {0} is {1}", number, binaryNumber);
        }
    }

    private static string BinaryToHexadecimalConverter(string number)
    {
        string hex = null;

        if (number.Length != 0)
        {
            for (int i = 0; i < number.Length; i= i+4)
            {
                string subsBinary = number.Substring(i, 4);
                string subsHex = null;

                switch (subsBinary)
                {
                    case "0000": subsHex = "0"; break;
                    case "0001": subsHex = "1"; break;
                    case "0010": subsHex = "2"; break;
                    case "0011": subsHex = "3"; break;
                    case "0100": subsHex = "4"; break;
                    case "0101": subsHex = "5"; break;
                    case "0110": subsHex = "6"; break;
                    case "0111": subsHex = "7"; break;
                    case "1000": subsHex = "8"; break;
                    case "1001": subsHex = "9"; break;
                    case "1010": subsHex = "A"; break;
                    case "1011": subsHex = "B"; break;
                    case "1100": subsHex = "C"; break;
                    case "1101": subsHex = "D"; break;
                    case "1110": subsHex = "E"; break;
                    case "1111": subsHex = "F"; break;
                    default: break;
                }
                hex = hex + subsHex;
            }
        }
        return hex;
    }
}

