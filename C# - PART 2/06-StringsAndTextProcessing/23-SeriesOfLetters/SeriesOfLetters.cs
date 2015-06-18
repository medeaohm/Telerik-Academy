/*	### Problem 23. Series of letters
*	Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

_Example:_

|          input          |  output  |
|:-----------------------:|:--------:|
| aaaaabbbbbcdddeeeedssaa | abcdedsa | */

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main(string[] args)
    {
        //aaaaabbbbbcdddeeeedssaa
        Console.Write("Enter some string: ");
        string input = Console.ReadLine();

        if (input.Length == 0)
        {
            Console.WriteLine("No characters to show!");
            return;
        }

        StringBuilder result = new StringBuilder();
        char lastChar = '\0';

        foreach (var letter in input)
        {
            if (letter != lastChar)
                result.Append(letter);

            lastChar = letter;
        }

        Console.WriteLine(result);
    }
}