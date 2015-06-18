//### Problem 4. Maximal sequence 
//*	Write a program that finds the **maximal sequence** of equal elements in an array.

//_Example:_

//|              input               | result  |
//|----------------------------------|---------|
//| 2, 1, 1, 2, 3, 3, **2, 2, 2**, 1 | 2, 2, 2 |

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Please choose the array dimension:");
        int dim = int.Parse(Console.ReadLine());
        int[] ar = new int[dim];
        int count = 0;
        int maxCount=1;
        Console.WriteLine("Please insert {0} elementns for the array:", dim);
        int[] eq = new int[dim];
        int val = 0;
        for (int i = 0; i < dim; i++)
        {
            ar[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < dim; i++)
        {
            count = 1;
            for (int j = i+1; j < dim; j++)
            {
                if (ar[i] == ar[j])
                {
                    count++;
                }
                else
                {
                    break;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    val = ar[i];
                }
            }
        }
        int[] finalAr = new int[maxCount];
        for (int i = 0; i < maxCount; i++)
        {
            finalAr[i] = val;
            Console.Write("{0}, ", finalAr[i]);
        }
    }
}

