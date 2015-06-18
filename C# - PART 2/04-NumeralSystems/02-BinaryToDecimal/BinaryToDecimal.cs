

using System;
using System.Text;


class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Please insert a binary number... Number = ");
        string number = Console.ReadLine();

        int decimalNumber = BinaryToDecimalConverter(number);
        Console.WriteLine("The decimal rapresentation of {0} is {1}", number, decimalNumber);
    }

    private static int BinaryToDecimalConverter(string binary)
    {
        int decimalNumber = 0;
        byte exp = 1;
        string newBinary = null;
        for (int i = 0; i < binary.Length; i++)
        {
            newBinary = newBinary + binary.Substring(binary.Length - 1 - i, 1);
        }

        for (int i = 0; i < binary.Length; i++)
        {
            exp *= 2;
            if (i == 0)
            {
                exp = 1;
            }
            byte subs = byte.Parse(newBinary.Substring(i,1));
            
            decimalNumber += exp * subs;
        }
        return decimalNumber;
    }
}