using System;

//### Problem 1.	Odd or Even Integers
//*	Write an expression that checks if given integer is odd or even.

//_Examples:_

//|  n |  Odd? |
//|:--:|:-----:|
//| 3  | true  |
//| 2  | false |
//| -2 | false |
//| -1 | true  |
//| 0  | false |

class OddOrEven
    {
        static void Main()
        {
            int n = 0;
            int rest = n%2;
            if (rest==0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

        }
    }

