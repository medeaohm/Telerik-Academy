//### Problem 1. Decimal to binary
//*	Write a program to convert decimal numbers to their binary representation.

using System;
using System.Text;


class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Please insert a positive integer number... Number = ");
        int number = int.Parse(Console.ReadLine());

        string binaryNumber = DecimalToBinaryConverter(number);
        Console.WriteLine("The binary rapresentation of {0} is {1}", number, binaryNumber);
    }

    private static string DecimalToBinaryConverter(int number)
    {
        string binary = null;

        if (number == 0)
        {
            binary = "0";
        }

        while (number != 0)
        {
            byte remainder = (byte)(number % 2);
            binary = remainder + binary;
            number /= 2;
        }
        return binary;
    }
}

