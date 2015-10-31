//1. Write a program that reads from the console a sequence of positive integer numbers.
//  - The sequence ends when empty line is entered.
//  - Calculate and print the sum and average of the elements of the sequence.
//  - Keep the sequence in `List<int>`.

using System;
using System.Linq;

public class SumAndAverage
{
    public static void Main()
    {
        Console.WriteLine("Enter a sequence of numbers separated with a space");

        var input = Console.ReadLine();
        var splittedInput = input.Split(' ').ToList();

        var sum = 0;

        for (int i = 0; i < splittedInput.Count; i++)
        {
            sum += int.Parse(splittedInput[i]);
        }

        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Average = {0}", sum/splittedInput.Count());
    }
}
