using System;

//### Problem 5.	Third Digit is 7?
//*	Write an expression that checks for given integer if its third digit from right-to-left is `7`.

//_Examples:_

//|    n    | Third digit 7? |
//|:-------:|:--------------:|
//| 5       | false          |
//| 701     | true           |
//| 9703    | true           |
//| 877     | false          |
//| 777877  | false          |
//| 9999799 | true           |


class ThirdDigit
    {
        static void Main()
        {
            int number = 9999799;
            bool isSeven = ((number / 100) % 10) == 7;
            Console.WriteLine("Is the third digit of {0} 7? --> {1}", number, isSeven);
        }
    }

