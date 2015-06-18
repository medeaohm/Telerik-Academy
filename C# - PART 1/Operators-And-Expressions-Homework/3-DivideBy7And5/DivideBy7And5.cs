using System;

//### Problem 3.	Divide by 7 and 5
//*	Write a Boolean expression that checks for given integer if it can be divided (without remainder) by `7` and `5` at the same time.

//_Examples:_

//|  n  | Divided by 7 and 5? |
//|:---:|:-------------------:|
//| 3   | false               |
//| 0   | false               |
//| 5   | false               |
//| 7   | false               |
//| 35  | true                |
//| 140 | true                |


class DivideBy7And5
    {
        static void Main()
        {
            int number = 140;
            bool divBy7 = (number % 7 == 0);
            bool divBy5 = (number % 5 == 0);
            Console.WriteLine("Can the number {0} be divided by 7 and 5? --> {1}", number, divBy5 && divBy7);
        }
    }

