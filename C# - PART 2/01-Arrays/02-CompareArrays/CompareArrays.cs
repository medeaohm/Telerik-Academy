//### Problem 2. Compare arrays
//*	Write a program that reads two `integer` arrays from the console and compares them element by element.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Please choose the array dimension:");
        int dim = int.Parse(Console.ReadLine());
        int[] ar1 = new int[dim];
        int[] ar2 = new int[dim];
        bool equal = true;
        Console.WriteLine("Please insert {0} elementns for the array 1:", dim);
        for (int i = 0; i < dim; i++)
        {
            ar1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please insert {0} elementns for the array 2:", dim);
        for (int i = 0; i < dim; i++)
        {
            ar2[i] = int.Parse(Console.ReadLine());
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

