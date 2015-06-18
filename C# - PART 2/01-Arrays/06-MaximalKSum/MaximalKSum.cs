//### Problem 6. Maximal K sum
//*	Write a program that reads two integer numbers `N` and `K` and an array of `N` elements from the console.
//*	Find in the array those `K` elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Please enter the array dimension... N =   ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Please enter an integer number K < N... K =  ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        List <int> subset = new List<int>(); 
        Console.WriteLine("Please insert {0} elementns for the array:", n);
        for (int index = 0; index < n; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        for (int i = arr.Length - 1; i >= 0 && k != 0; i--, k--)
        {
            subset.Add(arr[i]);
        }
        Console.WriteLine("Array's elements: {0} ", string.Join(", ", arr));
        Console.WriteLine("Subsequence with {0} element(s)",subset.Count);
        Console.WriteLine("Maximal Sum = {0}", subset.Sum());
        Console.WriteLine("Subset with Maximal Sum: {0}", string.Join(", ", subset));
        
    }
}

