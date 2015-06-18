/*### Problem 6. String length
*	Write a program that reads from the console a string of maximum `20` characters. If the length of the string is less than `20`, the rest of the characters should be filled with `*`.
*	Print the result string into the console. */

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Please enter a string");
        string input = Console.ReadLine();

        while (input.Length > 19)
        {
            Console.WriteLine("Invalid input! The length of the string should be less than 20");
            Console.WriteLine("Please enter a new string");
            input = Console.ReadLine();
        }

        string output = input.PadRight(20, '*');
        Console.WriteLine(output);
    }
}
