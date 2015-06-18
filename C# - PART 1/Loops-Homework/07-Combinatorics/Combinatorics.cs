using System;
using System.Numerics;

//### Problem 7.	Calculate N! / (K! * (N-K)!)
//*	In combinatorics, the number of ways to choose `k` different members out of a group of `n` different elements (also known as the number of combinations) is calculated by the following formula:
//![formula](https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png)
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//*	Your task is to write a program that calculates `n! / (k! * (n-k)!)` for given `n` and `k` (1 < k < n < 100). Try to use only two loops.

//_Examples:_

//| n           | k | n! / (k! * (n-k)!) |
//|-------------|---|--------------------|
//| 3           | 2 | 3                  |
//| 4           | 2 | 6                  |
//| 10          | 6 | 210                |
//| 52          | 5 | 2598960            |

class Combinatorics
    {
        static void Main()
        {
            {
                Console.WriteLine("Please insert a positive integer number n (1 ... 100)...");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Please insert another positive integer k (1 ... 100) and k < n ...");
                int k = int.Parse(Console.ReadLine());

                BigInteger expr1 = 1;
                BigInteger expr2 = 1;

                if (k >= n | n >= 100 | k >= 100 | k <= 1 | n <= 1)
                {
                    Console.WriteLine("Invalid input!");
                }

                else if (n > k)
                {
                    for (int i = k + 1; i <= n; i++)
                    {
                        expr1 *= i;
                    }
                    for (int i = 1; i <= n - k; i++)
                    {
                        expr2 *= i;
                    }
                }

                int result = (int)(expr1 / expr2);
                Console.WriteLine(result);
            }
        }
    }

