//### Problem 8. Binary short
//*	Write a program that shows the binary representation of given 16-bit signed integer number (the C# type `short`).

using System;
using System.Text;


class BinaryShort
{
    static void Main()
    {
        Console.Write("Please insert a integer number -32767 <= N <= 32767... Number = ");
        short number = short.Parse(Console.ReadLine());

        string binaryNumber = DecimalToBinaryConverter(number);
        Console.WriteLine("The binary rapresentation of {0} is {1}", number, binaryNumber);
    }

    private static string DecimalToBinaryConverter(int number)
    {
        string binary = null;
        string sign = null;

        if (number < 0)
        {
            sign = "1";
            number = -number;
        }
        else if (number > 0)
        {
            sign = "0";
        }

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

        if (binary.Length < 15)
        {
            for (int i = binary.Length; i < 15; i++)
            {
                 binary = "0" + binary;
            }
        }
        binary = sign + binary;
        return binary;
    }
}

