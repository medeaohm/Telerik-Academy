using System;

//### Problem 1.	Numbers from 1 to N
//*	Write a program that enters from the console a positive integer `n` and prints all the numbers from `1` to `n`, on a single line, separated by a space.

//_Examples:_

//| n            | output    | 
//|--------------|-----------|
//| 3            | 1 2 3     | 
//| 5            | 1 2 3 4 5 |

class FromOneToN
    {
        static void Main()
        {
            Console.WriteLine("Please insert a positive integer number...");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }

