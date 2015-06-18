//### Problem 5. Larger than neighbours
//*	Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Please insert the array size... N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please insert the index... k = ");
        int k = int.Parse(Console.ReadLine());

        
        LargerThanNei(n, k);

        
    }

    private static void  LargerThanNei(int size, int index)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        if (index < 0 || index >= size)
        {
            Console.WriteLine("There is not such an element in the array!");
        }
        else if (index == size - 1 || index == 0)
        {
            Console.WriteLine("Invalid index: the element has no two neighbours.");
        }
        else if (array[index] > array[index + 1] & array[index] > array[index - 1])
        {
            Console.WriteLine("The element is larget than his two neighbours");
        }
        else if (array[index] == array[index + 1] & array[index] == array[index - 1])
        {
            Console.WriteLine("The element is equal than his two neighbours");
        }
        else
        {
            Console.WriteLine("The element is smaller then his two neighbours");
        }
    }
}

