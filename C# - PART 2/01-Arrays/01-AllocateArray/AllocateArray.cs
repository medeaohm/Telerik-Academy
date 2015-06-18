//### Problem 1. Allocate array
//*	Write a program that allocates array of `20` integers and initializes each element by its index multiplied by `5`.
//*	Print the obtained array on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AllocateArray
{
    static void Main()
    {
        int[] array = new int[20];
        Console.WriteLine("This is an array:");
        for (int i = 0; i < 20; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}

