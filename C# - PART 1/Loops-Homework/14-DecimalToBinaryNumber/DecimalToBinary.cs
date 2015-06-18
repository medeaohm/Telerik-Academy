﻿//### Problem 14.	Decimal to Binary Number
//*	Using loops write a program that converts an integer number to its binary representation.
//*	The input is entered as long. The output should be a variable of type string.
//*	Do not use the built-in .NET functionality.

//_Examples:_

//| decimal           | binary                       |
//|-------------------|------------------------------|
//| 0                 | 0                            |
//| 3                 | 11                           |
//| 43691             | 1010101010101011             |
//| 236476736         | 1110000110000101100101000000 |



using System;

class DecimalToBinary 
    {

       static void Main()
       {
            Console.Write("Enter a Number : ");
            long num = long.Parse(Console.ReadLine());
            long quot;
            string rem = "";
            string bin = "";
            if (num == 0)
            {
                bin = "0";
            }
            else
            {
                while (num >= 1)
                {
                    quot = num / 2;
                    rem += (num % 2).ToString();
                    num = quot;
                }
                
                for (int i = rem.Length - 1; i >= 0; i--)
                {
                    bin = bin + rem[i];
                }
            }
            Console.WriteLine("The Binary format for given number is {0}", bin);
        }
    }
        


