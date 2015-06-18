//### Problem 14. Quick sort
//*	Write a program that sorts an array of strings using the [Quick sort](http://en.wikipedia.org/wiki/Quicksort) algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class QuickSort
{
    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
                left++;

            while (numbers[right] > pivot)
                right--;

            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void QuickSort_Recursive(int[] arr, int left, int right)
    {
        // For Recusrion
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
                QuickSort_Recursive(arr, left, pivot - 1);

            if (pivot + 1 < right)
                QuickSort_Recursive(arr, pivot + 1, right);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Please enter the array dimension... N =   ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Please insert {0} elementns for the array:", n);

        for (int index = 0; index < n; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("QuickSort By Recursive Method");
        QuickSort_Recursive(arr, 0, arr.Length - 1);
        for (int i = 0; i < arr.Length; i++)
            Console.WriteLine(arr[i]);

        Console.WriteLine();
    }
}
