//### Problem 16.* Subset with sum S
//*	We are given an array of integers and a number `S`.
//*	Write a program to find if there exists a subset of the elements of the array that has a sum `S`.

//_Example:_

//|       input array                      | S  |     result    |
//|:--------------------------------------:|:--:|:-------------:|
//| 2, **1**, **2**, 4, 3, **5**, 2, **6** | 14 | yes           |

using System;
using System.Collections.Generic;
using System.Linq;


class SubsetWithSumS
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


        Console.Write("Please enter the sum to search... Sum =   ");
        int sum = int.Parse(Console.ReadLine());

    }
}

