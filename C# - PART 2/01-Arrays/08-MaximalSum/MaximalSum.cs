//### Problem 8. Maximal sum
//*	Write a program that finds the sequence of maximal sum in given array.

//_Example:_

//|                 input                |    result   |
//|--------------------------------------|-------------|
//| 2, 3, -6, -1, **2, -1, 6, 4**, -8, 8 | 2, -1, 6, 4 |

//*	_Can you do it with only one loop (with single scan through the elements of the array)?_


using System;
using System.Collections.Generic;
using System.Linq;


class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter the array dimension... N =   ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int start = 0;
        int end = 0; 
        int maxSum = int.MinValue;
        Console.WriteLine("Please insert {0} elementns for the array:", n);
        for (int index = 0; index < n; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }

        int startIndex = 0, currentSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }

            currentSum += arr[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = startIndex;
                end = i;
            }
        }
        Console.WriteLine("Array's elements: {0} ", string.Join(", ", arr));
        Console.WriteLine("Maximal sum: {0}", maxSum);
        Console.Write("Sequence of maximal sum: ");
        for (int i = start; i <= end; i++)
        {
            Console.Write(i != end ? arr[i] + ", " : arr[i] + "\n");
        }
    }
}

