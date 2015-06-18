//### Problem 4.  Appearance count
//*	Write a method that counts how many times given number appears in given array.
//*	Write a test program to check if the method is workings correctly.

using System;
using System.Collections.Generic;


class AppearanceCount
{
    static void Main()
    {
        Console.Write("Please insert the array size... N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please insert the number to search... k = ");
        int k = int.Parse(Console.ReadLine());

        int appearence = AppCount(n, k);
        if (appearence == 0)
        {
            Console.WriteLine("Number {0} not found in the array!", k);
        }
        else
        {
            Console.WriteLine("The number {0} appears {1} times in the array", k, appearence);
        }
    }

    private static int AppCount(int size, int number)
    {
        int count = 0;
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            if (array[i] == number)
            {
                count++;
            }
        }
        return count;
    }
}

