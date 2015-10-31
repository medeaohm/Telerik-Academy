//5. Write a program that removes from given sequence all negative numbers.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int>() { -1, 2, -2, 1, 1, -1, -1, -3, 3 };
        Console.WriteLine("Initial Sequence");
        Console.WriteLine(string.Join(", ", numbers));

        List<int> positiveSequance = numbers.Where(n => n >= 0).ToList();
        Console.WriteLine("Sequence after removig negative numbers");
        Console.WriteLine(string.Join(", ", positiveSequance));
    }
}

