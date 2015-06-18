//### Problem 3. English digit
//*	Write a method that returns the last digit of given integer as an English word.

//_Examples:_

//| input | output |
//|:-----:|:------:|
//| 512   | two    |
//| 1024  | four   |
//| 12309 | nine   |

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Please insert an integer number --> ");
        string number = Console.ReadLine();

        string lastDigit = LastDigitAsWord(number);
        Console.WriteLine("The last digit of the entered number is --> {0}", lastDigit);
    }

    private static string LastDigitAsWord(string number)
    {
        string lastDigit = number.Substring(number.Length - 1, 1);
        string lastDigitWord;

        switch (lastDigit)
        {
            case "0": lastDigitWord = "zero";   break;
            case "1": lastDigitWord = "one";    break;
            case "2": lastDigitWord = "two";    break;
            case "3": lastDigitWord = "three";  break;
            case "4": lastDigitWord = "four";   break;
            case "5": lastDigitWord = "five";   break;
            case "6": lastDigitWord = "six";    break;
            case "7": lastDigitWord = "seven";  break;
            case "8": lastDigitWord = "eight";  break;
            case "9": lastDigitWord = "nine";   break;
            default: lastDigitWord = "Invalid Input";   break;
        }
        return lastDigitWord;
    }
}

