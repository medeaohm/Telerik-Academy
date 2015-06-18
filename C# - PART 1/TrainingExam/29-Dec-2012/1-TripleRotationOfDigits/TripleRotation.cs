using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TripleRotation
{
    static void Main()
    {
        string num = Console.ReadLine();
        char[] numbers = num.ToCharArray();
        int numL = numbers.Length;

        string num1 = num.Substring(num.Length-1, 1)+ num.Substring(0, num.Length-1);
//        Console.WriteLine(num1);
        string num2= num1;
        for (int i = 0; i < num1.Length; i++)
        {
            if (num2.Substring(0, 1) == "0")
            {
                num2 = num2.Substring(1, num2.Length-1);
            }
            else
            {
                break;
            }
        }
//        Console.WriteLine(num2);
        string num3 = num2.Substring(num2.Length -1, 1) + num2.Substring(0, num2.Length -1);
//        Console.WriteLine(num3);
        string num4 = num3;
        for (int i = 0; i < num3.Length; i++)
        {
            if (num4.Substring(0, 1) == "0")
            {
                num4 = num4.Substring(1, num4.Length - 1);
            }
            else
            {
                break;
            }
        }
 //       Console.WriteLine(num4);
        string num5 = num4.Substring(num4.Length - 1, 1) + num4.Substring(0, num4.Length - 1);
 //       Console.WriteLine(num5);
        string num6 = num5;
        for (int i = 0; i < num5.Length; i++)
        {
            if (num6.Substring(0, 1) == "0")
            {
                num6 = num6.Substring(1, num6.Length - 1);
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(num6);
    }
}

