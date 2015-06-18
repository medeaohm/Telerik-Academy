//### Problem 2. Maximal sum
//*	Write a program that reads a rectangular matrix of size `N x M` and finds in it the square `3 x 3` that has maximal sum of its elements.

using System;
using System.Collections.Generic;


class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("This program reads a rectangular matrix of size `N x M` and finds in it the square `3 x 3` that has maximal sum of its elements. \n");

        Console.WriteLine("Please insert matrix size...");
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        
        // fill the matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Element [{0},{1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }


        // print the matrix
        Console.WriteLine("\nThe matrix entered is... \n");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }


/* ----------------------- MATRIX FOR TESTING -> COMMENT ABOVE AND UNCOMMENT THE MATRIX BELOW -------------------------- */

        //for (int row = 0; row < n; row++)
        //{
        //    for (int col = 0; col < m; col++)
        //    {
        //        matrix[row, col] = row + col;
        //        Console.Write(matrix[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}

/*----------------------------------------------------------------------------------------------------------------------*/

        int maxSum = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + +matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }    
            }
        }
        Console.WriteLine("\n");
        Console.WriteLine("The maximum sum is -> {0} \n", maxSum);
    }
}

