using System;

//### Problem 1. Exchange If Greater
//*	Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

//_Examples:_

//| a    | b   | result  |
//|------|-----|---------|
//| 5    | 2   | 2 5     |
//| 3    | 4   | 3 4     |
//| 5.5  | 4.5 | 4.5 5.5 |

class ExchangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("Give me 2 numbers... I'll find which one is grater and I will print them by ascending order... \n");
            Console.WriteLine("Please insert the first number");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the second number");
            float secondNum = float.Parse(Console.ReadLine());
            float greater = secondNum;
            float lower = firstNum;

            if (secondNum < firstNum)
            {
                greater = firstNum;
                lower = secondNum;
            }
            Console.WriteLine("{0} {1}", lower, greater);
        }
    }

