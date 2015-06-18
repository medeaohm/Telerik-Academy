using System;

//### Problem 4. Multiplication Sign
//*	Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//    *	Use a sequence of `if` operators.

//_Examples:_

//| a    | b    | c    | result |
//|------|------|------|:------:|
//| 5    | 2    | 2    | +      |
//| -2   | -2   | 1    | +      |
//| -2   | 4    | 3    | -      |
//| 0    | -2.5 | 4    | 0      |
//| -1   | -0.5 | -5.1 | -      |

class SignMultiplication
{
    static void Main()
    {
        Console.WriteLine("Insert 3 numbers and I will tell you the sign of their multiplication...\n");
        Console.WriteLine("Please insert the first number...");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Please insert the second number...");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Please insert the third number...");
        float c = float.Parse(Console.ReadLine());


        if (a == 0 | b == 0 | c == 0)
        {
            Console.WriteLine("0"); ;
        }
        else
        {
            if (a < 0)
            {
                if ((b > 0 & c > 0) | (b < 0 & c < 0))
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
            else
            {
                if (b < 0)
                {
                    if (c < 0)
                    {
                        Console.WriteLine("+");
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                }
                else if (b > 0)
                {
                    if (c < 0)
                    {
                        Console.WriteLine("-");
                    }
                    else
                    {
                        Console.WriteLine("+");
                    }
                }
            }
        }
    }
}
