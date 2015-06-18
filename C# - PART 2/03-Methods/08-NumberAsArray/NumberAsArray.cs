//### Problem 8. Number as array
//*	Write a method that adds two positive integer numbers represented as arrays of digits (each array element `arr[i]` contains a digit; the last digit is kept in `arr[0]`).
//*	Each of the numbers that will be added could have up to `10 000` digits.

using System;
using System.Collections.Generic;
using System.Text;


class NumberAsArray
{
    static void Main()
    {
        Console.Write("Please insert the first number... A = ");
        string a = Console.ReadLine();
        Console.Write("Please insert the first number... B = ");
        string b = Console.ReadLine();
        Console.WriteLine(a.Substring(0,1));

        int sum = int.Parse(TransformToArrayAndSum(a, b, CheckLenght(a,b)));
        Console.WriteLine("The sum is... SUM = {0}", sum);
    }



    private static byte CheckLenght(string number1, string number2)
    {
        byte lenght = 0;
        if (number1.Length > number2.Length)
        {
            lenght = (byte)number1.Length;
        }
        else if (number1.Length <= number2.Length)
        {
            lenght = (byte)number2.Length;
        }
        return lenght;
    }


    private static string TransformToArrayAndSum(string longer, string shorter, byte length)
    {
        byte[] arrayS = new byte[length+1];
        byte[] arrayL = new byte[length+1];
        byte[] sum = new byte[length+1];
        string[] sumS = new string[length + 1];
        byte remaining = 0;
       

        if (longer.Length < length)
        {
            string temp = longer;
            longer = shorter;
            shorter = temp;
        }

        int step = longer.Length - shorter.Length;

        for (byte i = 0; i <= length; i++)
        {
            if (i == 0)
            {
                arrayS[i] = 0;
                arrayL[i] = 0;
            }
            else if (i <= step)
            {
                arrayS[i] = 0;
                arrayL[i] = byte.Parse(longer.Substring(i - 1, 1));
            }
            else
            {
                arrayS[i] = byte.Parse(shorter.Substring(i - step - 1, 1));
                arrayL[i] = byte.Parse(longer.Substring(i-1, 1));
            }
        }
        for (int i = 0; i <= length; i++)
		{
            sum[i] = (byte)(arrayL[length - i] + arrayS[length - i]);
            if (remaining == 1)
            {
                sum[i] = (byte)(sum[i] + 1);
            }
            if (sum[i] >= (byte)10)
            {
                sum[i] = (byte)(sum[i] - 10);
                remaining = 1;
            }
            else 
            {
                remaining = 0;
            }
            if (i == length && sum[0] >= 10)
            {
                sum[0] = 1;
            }
            sumS[i] = sum[i].ToString(); 
        }
        Array.Reverse(sumS);
        string result = string.Join("",sumS);
        return result;
    }
}

