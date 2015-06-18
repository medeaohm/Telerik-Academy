//### Problem 10. Find sum in array
//*	Write a program that finds in given array of integers a sequence of given sum `S` (if present).

//_Example:_

//|        array            |  S |  result |
//|-------------------------|----|---------|
//| 4, 3, 1, **4, 2, 5**, 8 | 11 | 4, 2, 5 |

using System;
using System.Collections.Generic;
using System.Linq;

class FindSum
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

        
        int sumArr = 0;
        int start = 0;
        int end = arr.Length;
        int sumStart = 0;
        int sumEnd = 0;

        for (int i = start; i < end; i++)
        {
            for (int j = i; j < end; j++)
            {
                sumArr = 0;
                for (int k = i; k < end; k++)
			    {
			    sumArr += arr[k];
                    if (sumArr == sum)
                    {
                        sumStart = i;
                        sumEnd = k;
                        break;
                    }
                    else if (sumArr > sum)
                    {
                        break;
                    } 
			    }
                    end --;
            }
            end = arr.Length;

            if (sumArr == sum)
            {
                break;
            }
            else
            {
                continue;
            }
        }

        if (sumArr != sum)
        {
            Console.WriteLine("In the array there is not subset wits sum {0}", sum);
        }
        else
        {
            Console.Write("Array's elements with sum {0} : ", sum);
            for (int i = sumStart; i <= sumEnd; i++)
            {
                Console.Write(arr[i] + "   ");
            }
            Console.WriteLine(); 
        }
    }
}

