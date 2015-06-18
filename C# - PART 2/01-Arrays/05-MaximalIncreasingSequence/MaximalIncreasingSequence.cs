//### Problem 5. Maximal increasing sequence
//*	Write a program that finds the maximal increasing sequence in an array.

//_Example:_

//|          input          | result  |
//|-------------------------|---------|
//| 3, **2, 3, 4**, 2, 2, 4 | 2, 3, 4 |


using System;
using System.Collections.Generic;
using System.Linq;


class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Please enter the array dimension... ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int maxCount = 0;
        int currentCount = 1;
        int sequenceStart = 0;
        Console.WriteLine("Please insert {0} elementns for the array:", n );
        for (int index = 0; index < n; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
            if (index != 0)
            {
                if (arr[index] > arr[index - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    sequenceStart = index + 1 - maxCount;
                }
            }
        }

        Console.Write("The maximal increasing sequence of elements is: ");
        for (int index = sequenceStart; index < sequenceStart + maxCount; index++)
        {
            Console.Write("{0} ", arr[index]);
        }
    }
}
