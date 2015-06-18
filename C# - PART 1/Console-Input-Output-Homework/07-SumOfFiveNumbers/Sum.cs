using System;

//### Problem 7.	Sum of 5 Numbers
//*	Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

//_Examples:_

//|      numbers      |  sum  |
//|-------------------|-------|
//| 1 2 3 4 5         | 15    |
//| 10 10 10 10 10    | 50    |
//| 1.5 3.14 8.2 -1 0 | 11.84 |

class Sum
    {
        static void Main()
        {
            Console.WriteLine("Please enter 5 numbers (given in a single line, separated by a space)");
            //Read line, and split it by whitespace into an array of strings
            string[] numbers = Console.ReadLine().Split();

            //Parse elements
            float a = float.Parse(numbers[0]);
            float b = float.Parse(numbers[1]);
            float c = float.Parse(numbers[2]);
            float d = float.Parse(numbers[3]);
            float e = float.Parse(numbers[4]);

            float sum = a + b + c + d + e;
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
