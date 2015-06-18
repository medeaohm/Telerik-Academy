using System;

//### Problem 1.	Sum of 3 Numbers
//*	Write a program that reads 3 real numbers from the console and prints their sum.

//_Examples:_

//|      a      |   b  |   c  |  sum |
//|:-----------:|:----:|:----:|:----:|
//| 3           | 4    | 11   | 18   |
//| -2          | 0    | 3    | 1    |
//| 5.5         | 4.5  | 20.1 | 30.1 |

class Sum
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third number");
        float c = float.Parse(Console.ReadLine());

        float sum = a + b + c;

        Console.WriteLine("The sum is....");
        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, sum);
    }
}

