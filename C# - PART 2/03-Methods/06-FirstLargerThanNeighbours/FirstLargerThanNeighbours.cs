//### Problem 6. First larger than neighbours
//*	Write a method that returns the index of the first element in array that is larger than its neighbours, or `-1`, if there's no such element.
//*	Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Please insert the array size... N = ");
        int n = int.Parse(Console.ReadLine());
        //Console.Write("Please insert the index... k = ");
        //int k = int.Parse(Console.ReadLine());

        int res = FirstLargerThanNei(n);
        if (res == -1)
        {
            Console.WriteLine("Such an element does not exist");
        }
        else
        {
            Console.WriteLine("The index of the first element greater than its neighbours is --> {0}", res);
        }

    }

    private static int FirstLargerThanNei(int size)
    {
        int res = 0;
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < size-1; i++)
        {
            if (array[i] > array[i + 1] & array[i] > array[i - 1])
            {
                res = i;
                break;
            }
            else
            {
                res = -1;
            }
        }
        return res;
    }
}

