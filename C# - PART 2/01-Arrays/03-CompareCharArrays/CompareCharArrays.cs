//### Problem 3. Compare char arrays
//*	Write a program that compares two `char` arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;



class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Please choose the array dimension:");
        int dim = int.Parse(Console.ReadLine());
        char[] ar1 = new char[dim];
        char[] ar2 = new char[dim];
        bool equal = true;
        Console.WriteLine("Please insert {0} elementns for the array 1:", dim);
        for (int i = 0; i < dim; i++)
        {
            ar1[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please insert {0} elementns for the array 2:", dim);
        for (int i = 0; i < dim; i++)
        {
            ar2[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < dim; i++)
        {
            if (ar1[i] != ar2[i])
            {
                equal = false;
                break;
            }
        }
        if (equal)
        {
            Console.WriteLine("The arrays are equal");
        }
        else
        {
            Console.WriteLine("The arrays are not equal");
        }
    }
}

