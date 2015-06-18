//### Problem 10. N Factorial
//*	Write a program to calculate `n!` for each `n` in the range [`1..100`].

//_Hint: Implement first a method that multiplies a number represented as array of digits by given integer number._

using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;


class NFactorial
{
    static void Main()
    {
        BigInteger[] factorial = CalculateFactorial();
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("{0}! = {1}", i+1, factorial[i]);
        }
    }

    private static BigInteger[] CalculateFactorial()
    {
        int[] array = new int[100];
        BigInteger[] factorial = new BigInteger[100];
        BigInteger fact = 1;

        for (int i = 0; i < 100; i++)
        {
            array[i] = i + 1;
        }

        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                fact *= array[j];
            }
            factorial[i] = fact;
            fact = 1;
        }
        return factorial;
    }
    
}
