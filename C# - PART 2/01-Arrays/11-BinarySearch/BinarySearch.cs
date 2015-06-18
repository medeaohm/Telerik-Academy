//### Problem 11. Binary search
//*	Write a program that finds the index of given element in a sorted array of integers by using the [Binary search](http://en.wikipedia.org/wiki/Binary_search_algorithm) algorithm.


using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
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

        Console.Write("Please enter the element to search... Element =   ");
        int el = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        Console.WriteLine("Array before sorting: {0} ", string.Join(", ", arr));

        Array.Sort(arr);
        Console.WriteLine("Array after sorting: {0} ", string.Join(", ", arr));
        
        int ind = 0;
        int middle = (arr.Length - 1) / 2;

        if (el > arr[arr.Length - 1])
        {
            ind = -1;
        }

        else if (el == arr[middle])
        {
            ind = middle;
        }

        else if (el < arr[middle])
        {
            for (int i = middle -1 ; i >= 0; i--)
            {
                if (el == arr[i])
                {
                    ind = i;
                    break;
                }
                else if (el > arr[i])
                {
                    ind = -1;
                    break;
                }
                else
                {
                    middle--;
                }
            }
        }

        else if (el > arr[middle])
        {
            for (int i = middle + 1; i < arr.Length; i++)
            {
                if (el == arr[i])
                {
                    ind = i;
                    break;
                }
                else if (el > arr[i])
                {
                    middle++;
                }
                else
                {
                    break;
                }
            }
        }


        if (ind == -1)
        {
            Console.WriteLine("Ther is not such an element in the array"); 
        }
        else
        {
            Console.WriteLine("The index of {0} in the sorted array is ... -> {1}", el, ind);
        }
    }
}

