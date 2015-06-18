//### Problem 5. Sort by string length
//*	You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SortByStringLenght
{
    static void Main()
    {
        Console.WriteLine("This program sorts an array of strings by the lenght of its elements! \n");
        Console.Write("Please insert the array dimension... N = ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = Console.ReadLine();
        }

        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Array[{0}] = {1} ", i, array[i]);
        }
    }
}

