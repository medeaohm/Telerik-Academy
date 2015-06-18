using System;
using System.Text;



class HexadecimalToBinary
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
            string hexadecimalNumber = HexadecimalToBinaryConverter(number);
            Console.WriteLine("The binary rapresentation of {0} is {1}", number, hexadecimalNumber); 
        }
    }

    private static string HexadecimalToBinaryConverter(string number)
    {
        string binary = null;
 
        if (number.Length != 0)
        {
            for (int i = 0; i < number.Length; i++)
            {
  
            string subsHex = number.Substring(i,1);
            string subsB = null;
                        
            switch (subsHex)
            {
                case "0": subsB = "0000";  break;
                case "1": subsB = "0001";  break;
                case "2": subsB = "0010";  break;
                case "3": subsB = "0011";  break;
                case "4": subsB = "0100";  break;
                case "5": subsB = "0101";  break;
                case "6": subsB = "0110";  break;
                case "7": subsB = "0111";  break;
                case "8": subsB = "1000";  break;
                case "9": subsB = "1001";  break;
                case "A": subsB = "1010";  break;
                case "B": subsB = "1011";  break;
                case "C": subsB = "1100";  break;
                case "D": subsB = "1101";  break;
                case "E": subsB = "1110";  break;
                case "F": subsB = "1111";  break;
                default:            break;
            }
            binary = binary + subsB;
        }
    }
    return binary;
    }
}

