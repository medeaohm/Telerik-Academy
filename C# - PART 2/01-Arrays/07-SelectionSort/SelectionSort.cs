//### Problem 7. Selection sort
//*	**Sorting** an array means to arrange its elements in increasing order. Write a program to sort an array.
//*	Use the [Selection sort](http://en.wikipedia.org/wiki/Selection_sort) algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.


using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Please enter the array dimension... N =   ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Please insert {0} elementns for the array:", n);
        for (int index = 0; index < n; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Before sorting: ");
        Console.WriteLine(string.Join(" ", arr));

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int index = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[index])
                {
                    index = j;
                }
            }
            int swap = arr[i];
            arr[i] = arr[index];
            arr[index] = swap;
        }

        Console.Write("After sorting: ");
        Console.WriteLine(string.Join(" ", arr) + "\n");
    }
}
