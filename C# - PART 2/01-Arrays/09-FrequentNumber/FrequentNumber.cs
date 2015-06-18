//### Problem 9. Frequent number
//*	Write a program that finds the most frequent number in an array.

//_Example:_

//|                  input                                    |    result   |
//|-----------------------------------------------------------|-------------|
//| **4**, 1, 1, **4**, 2, 3, **4**, **4**, 1, 2, **4**, 9, 3 | 4 (5 times) |


using System;
using System.Collections.Generic;
using System.Linq;


class FrequentNumber
{
    static void Main()
    {
        Console.Write("Please enter the array dimension... N =   ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int freqNum = 0;
        int count = 0;
        int maxCount = 0;
        Console.WriteLine("Please insert {0} elementns for the array:", n);
        for (int index = 0; index < n; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            count = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                freqNum = arr[i];
            }
        }
        if (maxCount == 1)
        {
            Console.WriteLine("All the numbers in the array are different...");
        }
        else
        {
            Console.WriteLine("The most frequent number in the array is -> {0}", freqNum);
            Console.WriteLine("It appears -> {0} times", maxCount);
        }
    }
}

