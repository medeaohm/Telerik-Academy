using System;
using System.Text;


class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Please insert a positive integer number... Number = ");
        int number = int.Parse(Console.ReadLine());

        string hexadecimalNumber = DecimalToHexadecimalConverter(number);
        Console.WriteLine("The hexadecimal rapresentation of {0} is {1}", number, hexadecimalNumber);
    }

    private static string DecimalToHexadecimalConverter(int number)
    {
        string hex = null;
        if (number == 0)
        {
            hex = "0";
        }

        while (number != 0)
        {
            byte remainder = (byte)(number % 16);
            string rem = null;
            switch (remainder)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: rem = remainder.ToString(); break;
                case 10: rem = "A"; break;
                case 11: rem = "B"; break;
                case 12: rem = "C"; break;
                case 13: rem = "D"; break;
                case 14: rem = "E"; break;
                case 15: rem = "F"; break;
                default:            break;
            }
            hex = rem + hex;
            number /= 16;
        }
        return hex;
    }
}

