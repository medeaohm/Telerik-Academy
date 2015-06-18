//### Problem 4. Binary search
//*	Write a program, that reads from the console an array of `N` integers and an integer `K`, sorts the array and using the method `Array.BinSearch()` finds the largest number in the array which is <= `K`. 

using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("This program reads from the console an array of N integers and an integer K, then finds the largest number in the array which is <= K \n");
        Console.Write("Please insert the array dimension... N = ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine()); 
        }
        Console.WriteLine("\n");
        Console.Write("Please insert the number which index you want to search... K = ");
        int k = int.Parse(Console.ReadLine());
       
        Array.Sort(array);
        if (Array.BinarySearch(array, k) >= 0) 
        {
            Console.WriteLine("The index of K = {0} is {1}", k, Array.BinarySearch(array, k));
        }
        else
        {
            while (Array.BinarySearch(array, k) < 0)
            {
                k--;
            }
            Console.WriteLine("{0} not found in the array!", k);
            Console.WriteLine("The largest number in the array < K is {0} and its index is {1}", k, Array.BinarySearch(array, k));
        }
    }
}

