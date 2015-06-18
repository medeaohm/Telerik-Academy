using System;

//### Problem 10.	Fibonacci Numbers
//*	Write a program that reads a number `n` and prints on the console the first `n` members of the Fibonacci sequence (at a single line, separated by comma and space - `, `) : `0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …`.

//_Note: You may need to learn how to use loops._

//_Examples:_

//|   n  |        comments        |
//|:----:|------------------------|
//| 1    | 0                      |
//| 3    | 0 1 1                  |
//| 10   | 0 1 1 2 3 5 8 13 21 34 |


class Fibonacci
    {
        static void Main()
        {
            Console.WriteLine("Please insert a integer number...");
            int n = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 1;
            int next = 0;
            Console.WriteLine("The first {0} members of the Fibonacci sequence are...", n);
            
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                {
                    next = i;  
                }
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.Write("{0}, ", next);           
            }
        }
    }

