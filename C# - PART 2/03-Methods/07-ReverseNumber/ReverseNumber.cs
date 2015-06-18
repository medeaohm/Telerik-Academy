//### Problem 7. Reverse number
//*	Write a method that reverses the digits of given decimal number.

//_Example:_

//| input | output |
//|:-----:|:------:|
//| 256   | 652    |

using System;
using System.Collections.Generic;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Please insert an integer number... N = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        
        decimal reverseNumber = Reverse(n);
        Console.WriteLine("The number N = {0} with all digits reversed is --> {1}", n, reverseNumber);
    }


    // this method return a decimal number, as the problem ask. There is a little issue with numbers ending with zero (zeros) becouse in the resulting number with reversed digits the zero desapear ( i.e. 20 --> 2 and not 02). To fix this problem it would be sufficient let the result be a string and not converting to decimal. 

    private static decimal Reverse(int number)
    {
        string num = number.ToString();
        char[] oldNumber = num.ToCharArray();
        char[] newNumber = new char[num.Length];
        
        for (int i = 0, j = num.Length - 1; i < num.Length; i++, j--)
        {
            newNumber[i] = oldNumber[j];
        }

        string newNum = new string(newNumber);
        decimal revNumber = decimal.Parse(newNum);
        return revNumber;
    }
}

