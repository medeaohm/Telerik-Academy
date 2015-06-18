using System;

//### Problem 4.	Number Comparer
//*	Write a program that gets two numbers from the console and prints the greater of them.
//*	Try to implement this without if statements.

//_Examples:_

//|  a  |  b  | greater |
//|:---:|:---:|:-------:|
//| 5   | 6   | 6       |
//| 10  | 5   | 10      |
//| 0   | 0   | 0       |
//| -5  | -2  | -2      |
//| 1.5 | 1.6 | 1.6     |

class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter two number and I will tell you which one is greater!");

            Console.WriteLine("Please enter the first number....");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number....");
            double b = double.Parse(Console.ReadLine());

            double grater = Math.Max(a, b);
            Console.WriteLine("Between {0} and {1} the greater is ... {2}", a, b, grater);
        }
    }
