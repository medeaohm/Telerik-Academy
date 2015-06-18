//### Problem 18.* Trailing Zeroes in N!
//*	Write a program that calculates with how many zeroes the factorial of a given number `n` has at its end.
//*	Your program should work well for very big numbers, e.g. `n=100000`.

//_Examples:_

//| n      | trailing zeroes of n! | explaination        |
//|--------|-----------------------|---------------------|
//| 10     | 2                     | 3628800             |
//| 20     | 4                     | 2432902008176640000 |
//| 100000 | 24999                 | think why           |

using System;
using System.Numerics;

class TrailingZeroes
    {
        static void Main()
        {
             Console.WriteLine("Please insert a positive integer number n ...");
            int n = int.Parse(Console.ReadLine());

            BigInteger fact = 1;
            int zeros = 0;
            
            for (int i = 1; i <= n; i++)
			{
			    fact *= i; 
			}   
            Console.WriteLine("n! = {0}", fact);
            while ((fact % 10) == 0)
            {
                fact = fact / 10;
                zeros++;
            }
           
            Console.WriteLine("Trailing Zeros --> {0}", zeros);
        }
    }

