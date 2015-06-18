//### Problem 6. Sum integers
//*	You are given a sequence of positive integer values written into a string, separated by spaces.
//*	Write a function that reads these values from given string and calculates their sum.

//_Example:_

//|      input       | output |
//|------------------|:------:|
//| "43 68 9 23 318" | 461    |

using System;
using System.Text;

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter some numbers, on the same line, separated by space");
        string numbers = Console.ReadLine();
        string[] separator = new string[] {" "};
        string[] number;

        number = numbers.Split(separator, StringSplitOptions.None);

        int num = 0;
        int sum = 0;

        for (int i = 0; i < number.Length; i++)
        {
            num = int.Parse(number[i]);
            sum += num;
        }

        Console.WriteLine("\nThe sum of the numbers is {0}\n", sum);
    }
}

