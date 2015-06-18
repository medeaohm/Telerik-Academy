using System;

//### Problem 5. The Biggest of 3 Numbers
//*	Write a program that finds the biggest of three numbers.

//_Examples:_

//| a    | b    | c    | biggest |
//|------|------|------|:-------:|
//| 5    | 2    | 2    | 5       |
//| -2   | -2   | 1    | 1       |
//| -2   | 4    | 3    | 4       |
//| 0    | -2.5 | 5    | 5       |
//| -0.1 | -0.5 | -1.1 | -0.1    |

class BiggestOfThree
    {
        static void Main()
        {
            Console.WriteLine("Insert 3 numbers and I will tell you which one is the biggest one...\n");
            Console.WriteLine("Please insert the first number...");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the second number...");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the third number...");
            float c = float.Parse(Console.ReadLine());

            float bigger = a;
            if (b > a & b > c)
            {
                bigger = b; 
            }
            else if (c > a & c > b)
            {
                bigger = c;
            }
            Console.WriteLine("And the biggest one is .... \n {0}");
        }
    }

