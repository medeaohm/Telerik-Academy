using System;

//### Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
//*	Write a program that, for a given two integer numbers `n` and `x`, calculates the sum `S = 1 + 1!/x + 2!/x2 + … + n!/xn`.
//*	Use only one loop. Print the result with `5` digits after the decimal point.

//_Examples:_

//| n           | x          | S       |
//|-------------|------------|---------|
//| 3           | 2          | 2.75000 |
//| 4           | 3          | 2.07407 |
//| 5           | -4         | 0.75781 |

class Math
{
    static void Main()
    {
        Console.WriteLine("Please insert a positive integer number...");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please insert another integer number...");
        int x = int.Parse(Console.ReadLine());

        decimal factorial = 1.00m;
        decimal pow = 1.00m;
        decimal expr = 1.00m;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            pow = pow * x;
            expr += (factorial / pow);
        }
        Console.WriteLine(expr);
    }
}


