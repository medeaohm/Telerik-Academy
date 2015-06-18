//### Problem 12.* Randomize the Numbers 1…N
//*	Write a program that enters in integer `n` and prints the numbers `1, 2, …, n` in random order.

//_Examples:_

//| n                 | randomized numbers 1…n |
//|-------------------|------------------------|
//| 3                 | 2 1 3                  |
//| 10                | 3 4 8 2 6 7 9 1 10 5   |

//_Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays._



using System;
using System.Collections.Generic;
using System.Linq;

class Randomize
    {
        static void Main()
        {
            Console.Write("Please insert a positive integer number... n =");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                int[] numbers = new int[n];
                Random index = new Random();

                for (int i = 0; i < n; i++)
                {
                    numbers[i] = i + 1;
                }

                int[] shuffled = numbers.OrderBy(k => Guid.NewGuid()).ToArray();
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0} ", shuffled[i]);
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            } 
        }
    }

