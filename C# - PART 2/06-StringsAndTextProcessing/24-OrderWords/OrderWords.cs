//### Problem 24. Order words
//*	Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Text;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Please enter a list of word separated by space: ");
        string list = Console.ReadLine();

        string[] words = list.Split(' ');
        Array.Sort(words);

        Console.WriteLine("\nList in alphabetical order:");
        Console.WriteLine("{0}", String.Join(", ", words));
    }
}

