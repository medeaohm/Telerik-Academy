using System;
using System.Numerics;

//### Problem 6.	Calculate N! / K!
//*	Write a program that calculates `n! / k!` for given `n` and `k` (1 < k < n < 100).
//*	Use only one loop.

//_Examples:_

//| n           | k          | n! / k! |
//|-------------|------------|---------|
//| 5           | 2          | 60      |
//| 6           | 5          | 6       |
//| 8           | 3          | 6720    |

class Factorial
    {
        static void Main()
        {
            Console.WriteLine("Please insert a positive integer number n (1 ... 100)...");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert another positive integer k (1 ... 100) and k < n ...");
            int k = int.Parse(Console.ReadLine());

            BigInteger expr = 1;
            if (k >= n | n >= 100 | k >= 100 | k <= 1 | n <= 1)
            {
                Console.WriteLine("Invalid input!");
            }

            else if (n > k)
	        {
		        for (int i = k + 1; i <= n; i++)
			    {
			        expr *= i; 
			    }
	        }        
            Console.WriteLine(expr);
        }
    }

