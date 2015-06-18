using System;

//### Problem 6.	Four-Digit Number
//*	Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//    *	Calculates the sum of the digits (in our example `2 + 0 + 1 + 1 = 4`).
//    *	Prints on the console the number in reversed order: `dcba` (in our example `1102`).
//    *	Puts the last digit in the first position: `dabc` (in our example `1201`).
//    *	Exchanges the second and the third digits: `acbd` (in our example `2101`).
	
//The number has always exactly 4 digits and cannot start with 0.

//_Examples:_

//|    n    | sum of digits | reversed | last digit in front | second and third digits exchanged |
//|:-------:|:-------------:|:--------:|:-------------------:|:---------------------------------:|
//| 2011    | 4             | 1102     | 1201                | 2101                              |
//| 3333    | 12            | 3333     | 3333                | 3333                              |
//| 9876    | 30            | 6789     | 6987                | 9786                              |

class FourDigitNumber
    {
        static void Main()
        {
            int number = 9876;
            int firstDigit = (number/1000);
            int secondDigit = (number - (firstDigit * 1000)) / 100;
            int thirdDigit = (number - ((firstDigit*1000)+(secondDigit*100))) / 10;
            int fourthDigit = (number - ((firstDigit * 1000) + (secondDigit * 100) + (thirdDigit * 10)));
            
            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            int reverse = (fourthDigit * 1000) + (thirdDigit * 100) + (secondDigit * 10) + firstDigit;
            int lastFirst = (fourthDigit*1000) + (firstDigit*100) + (secondDigit*10) + thirdDigit;
            int exchenge = (firstDigit * 1000) + (secondDigit * 100) + (thirdDigit * 10) + firstDigit;

            Console.WriteLine("Number = {0}", number);
            Console.WriteLine(" First digit --> {0} \n Second digit --> {1} \n Third digit --> {2} \n Fourth digit --> {3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("Sum of the digits: {0}", sum);
            Console.WriteLine("Reverse order: {0}", reverse);
            Console.WriteLine("Last digit become first: {0}", lastFirst);
            Console.WriteLine("Exchange of second and third digits: {0}", exchenge);
        }
    }