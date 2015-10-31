//3. Write a program that reads a sequence of integers(`List<int>`) ending with an empty line and sorts them in an increasing order.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a sequence of numbers separated with a space");

        var input = Console.ReadLine();
        var splittedInput = input.Split(' ');

        List<int> inputList = new List<int>();

        foreach (var number in splittedInput)
        {
            inputList.Add(int.Parse(number));
        }

        inputList.Sort();

        Console.WriteLine("Sorted sequence:");
        foreach (var num in inputList)
        {
            Console.Write(num + " ");
        }
    }
}

