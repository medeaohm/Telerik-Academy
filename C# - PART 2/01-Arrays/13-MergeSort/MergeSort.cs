//### Problem 13.*  Merge sort
//*	Write a program that sorts an array of integers using the [Merge sort](http://en.wikipedia.org/wiki/Merge_sort) algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class MergeSort
{
     
    static public void DoMerge(int [] numbers, int left, int mid, int right)
    {
        int [] temp = new int[1000000];
        int i, left_end, num_elements, tmp_pos;
        
        left_end = (mid - 1);
        tmp_pos = left;
        num_elements = (right - left + 1);
        
        while ((left <= left_end) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[tmp_pos++] = numbers[left++];
            else
                temp[tmp_pos++] = numbers[mid++];
        }
        
        while (left <= left_end)
            temp[tmp_pos++] = numbers[left++];
 
        while (mid <= right)
            temp[tmp_pos++] = numbers[mid++];
 
        for (i = 0; i < num_elements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }
 
    static public void MergeSort_Recursive(int [] numbers, int left, int right)
    {
        int mid;
        
        if (right > left)
        {
        mid = (right + left) / 2;
        MergeSort_Recursive(numbers, left, mid);
        MergeSort_Recursive(numbers, (mid + 1), right);
        
        DoMerge(numbers, left, (mid+1), right);
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
        MergeSort_Recursive(arr, 0, arr.Length - 1);
        for (int i = 0; i < arr.Length; i++)
            Console.WriteLine(arr[i]);

        Console.WriteLine();
    }
}


