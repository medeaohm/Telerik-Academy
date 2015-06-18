//### Problem 9. Sorting array
//* Write a method that return the maximal element in a portion of array of integers starting at given index.
//* Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Text;


class SortingArray
{
    public static void Main()
    {
        Console.Write("Please insert the array size... N = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please insert the starting index... Index = ");
        int k = int.Parse(Console.ReadLine());

        while (k >= n || k < 0)
        {
            Console.WriteLine("Invalid index!");
            Console.Write("Please enter a valid index ( Index >= 0 and Index < N)... K = ");
            k = int.Parse(Console.ReadLine());
        }

        int[] arrayOriginal = CreateArray(n);
        int[] copyOfArrayAs =new int[n];
        int[] copyOfArrayDes = new int[n];
        Array.Copy(arrayOriginal, 0, copyOfArrayAs, 0, arrayOriginal.Length);
        Array.Copy(arrayOriginal, 0, copyOfArrayDes, 0, arrayOriginal.Length);
        int maxValue = MaxOfArrayPortion(arrayOriginal, k);
        int[] arrayAscending = ArrayInAscendingOrder(copyOfArrayAs);
        int[] arrayDescending = ArrayInDescendingOrder(copyOfArrayDes);

        Console.WriteLine("The original array is: {0}", String.Join(", ", arrayOriginal));
        Console.WriteLine("The maximum value in the subarray is {0}", maxValue);
        Console.WriteLine("The array sorted in ascending order is: {0}", String.Join(", ", arrayAscending));
        Console.WriteLine("The array sorted in descending order is: {0}", String.Join(", ", arrayDescending));
    }

    public static int[] CreateArray(int size)
    {
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    public static int MaxOfArrayPortion(int[] array, int start)
    {
        int length = array.Length;
        int max = Int32.MinValue;


        for (int i = start; i < length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    public static int[] ArrayInAscendingOrder(int[] array)
    {
        int[] sortedArrayAscending = new int[array.Length];
        int max = Int32.MinValue;
        int index = 0;

        for (int j = array.Length - 1; j >= 0; j--)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            sortedArrayAscending[j] = max;
            array[index] = Int32.MinValue;
            max = Int32.MinValue;
        }
        return sortedArrayAscending;
    }

    public static int[] ArrayInDescendingOrder(int[] array)
    {
        int[] sortedArrayDescending = new int[array.Length];
        int max = Int32.MinValue;
        int index = 0;

        for (int j = 0; j < array.Length; j++)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }

            sortedArrayDescending[j] = max;
            array[index] = Int32.MinValue;
            max = Int32.MinValue;
        }
        return sortedArrayDescending;
    }
}
