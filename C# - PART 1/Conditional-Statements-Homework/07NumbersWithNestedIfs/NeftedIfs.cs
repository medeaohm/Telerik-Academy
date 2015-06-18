using System;

//### Problem 7. Sort 3 Numbers with Nested Ifs
//*	Write a program that enters 3 real numbers and prints them sorted in descending order.
//    *	Use nested `if` statements.

//_Note: Don’t use arrays and the built-in sorting functionality._

//_Examples:_

//| a    | b    | c    |     result     |
//|------|------|------|=--------------=|
//| 5    | 1    | 2    | 5 2 1          |
//| -2   | -2   | 1    | 1 -2 -2        |
//| -2   | 4    | 3    | 4 3 -2         |
//| 0    | -2.5 | 5    | 5 0 -2.5       | 
//| -1.1 | -0.5 | -0.1 | -0.1 -0.5 -1.1 |
//| 10   | 20   | 30   | 30 20 10       |
//| 1    | 1    | 1    | 1 1 1          |


class NeftedIfs
    {
        static void Main()
        {
            Console.WriteLine("Insert 3 numbers and I will print them in descending order...\n");
            Console.WriteLine("Please insert the first number...");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the second number...");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the third number...");
            float c = float.Parse(Console.ReadLine());

            float firstNum = a;
            float secondNum = b;
            float thirdNum = c;

            if (a >= b & a >= c)
            {
                if (b >= c)
                {
                    firstNum = a;
                    secondNum = b;
                    thirdNum = c;
                }
                else
                {
                    firstNum = a;
                    secondNum = c;
                    thirdNum = b;
                }
            }

            else if (b >= a & b >= c)
            {
                if (a >= c)
                {
                    firstNum = b;
                    secondNum = a;
                    thirdNum = c;
                }
                else
                {
                    firstNum = b;
                    secondNum = c;
                    thirdNum = a;
                }
            }

            else if (c >= a & c >= b)
            {
                if (a >= b)
                {
                    firstNum = c;
                    secondNum = a;
                    thirdNum = b;
                }
                else
                {
                    firstNum = c;
                    secondNum = b;
                    thirdNum = a;
                }
            }
            Console.WriteLine("{0}, {1}, {2}", firstNum, secondNum, thirdNum);
        }
    }

