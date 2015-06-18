using System;

//### Problem 6. The Biggest of Five Numbers
//*	Write a program that finds the biggest of five numbers by using only five if statements.

//_Examples:_

//| a    | b    | c    |  d |   e  | biggest |
//|------|------|------|:--:|:----:|---------|
//| 5    | 2    | 2    | 4  | 1    | 5       |
//| -2   | -22  | 1    | 0  | 0    | 1       |
//| -2   | 4    | 3    | 2  | 0    | 4       |
//| 0    | -2.5 | 0    | 5  | 5    | 5       |
//| -3   | -0.5 | -1.1 | -2 | -0.1 | -0.1    |

class BiggestOfFive
    {
        static void Main()
        {
            Console.WriteLine("Insert 5 numbers and I will tell you which one is the biggest one...\n");
            Console.WriteLine("Please insert the first number...");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the second number...");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the third number...");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the forth number...");
            float d = float.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the fifth number...");
            float e = float.Parse(Console.ReadLine());

            float bigger = a;
            if (b > a & b > c & b > d & b > e)
            {
                bigger = b;
            }
            else if (c > a & c > b & c > d & c > e)
            {
                bigger = c;
            }
            else if (d > a & d > c & d > b & d > e)
            {
                bigger = d;
            }
            else if (e > a & e > b & e > c & e > d)
            {
                bigger = e;
            }
            Console.WriteLine("And the biggest one is .... \n {0}", bigger);
        }
    }

