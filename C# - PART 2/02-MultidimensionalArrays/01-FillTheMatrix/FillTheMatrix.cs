//### Problem 1. Fill the matrix
//*	Write a program that fills and prints a matrix of size `(n, n)` as shown below:

//_Example for `n=4`:_

//| a)         | b)        | c)         | d)*        |
//|:----------:|:---------:|:----------:|:----------:|
//| 1  5  9 13 | 1 8  9 16 | 7 11 14 16 | 1 12 11 10 |
//| 2  6 10 14 | 2 7 10 15 | 4  8 12 15 | 2 13 16  9 |
//| 3  7 11 15 | 3 6 11 14 | 2  5  9 13 | 3 14 15  8 |
//| 4  8 12 16 | 4 5 12 13 | 1  3  6 10 | 4  5  6  7 |

using System;
using System.Collections.Generic;
using System.Linq;

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("This program fills and prints a matrix of size `(n, n)` of several type \n");

        Console.Write("Please insert the matrix dimension... N = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        Console.WriteLine("The first matrix (a) is...");
        int[,] matrixA = new int[n, n];
        int a = 1;
        int b = 0;

        for (int row = 0; row < n; row++)
        {
            b = a;
            for (int col = 0; col < n; col++)
            {    
                matrixA[row, col] = b;
                b += n;
                Console.Write(matrixA[row,col]+ " ");
            }
            a++;
            Console.WriteLine();
        }
        Console.WriteLine("\n \n ");



        Console.WriteLine("The second matrix (b) is...");
        int[,] matrixB = new int[n, n];
        a = 1;
        int c = 2 * n;
        int d = 0;

        for (int row = 0; row < n; row++)
        {
            b = a;
            d = c;
                for (int col = 0; col < n; col++)
                {

                    if (col % 2 == 0)
                    {  
                        matrixB[row, col] = b;
                        b += 2 * n;
                        Console.Write(matrixB[row, col] + " ");
                    }  
                    else
	                {
                        matrixB[row, col] = d;
                        d += 2 * n;
                       Console.Write(matrixB[row, col] + " "); 
	                }
                }
            a++;
            c--;
            Console.WriteLine(); 
        }
        Console.WriteLine("\n \n");



        Console.WriteLine("The third matrix (c) is...");
        int[,] matrixC = new int[n, n];
        int maxCounter = n * n;
        int counter = 1;
        int rowCounter = 1;
        int colCounter = 0;

        for (int row = n-1; row >=0; row--)
        {
            for (int col = 0; col < n;)
            {
                matrixC[row, col] = counter;
                if (counter == maxCounter)
                {
                    break;
                }
                 else if (row == n - 1 && col != n - 1)
                {
                    row -= rowCounter;
                    col -= colCounter;
                    rowCounter++;
                    colCounter++;
                }
                else if (row == n - 1 || col == n - 1)
                {
                    colCounter--;
                    rowCounter--;
                    col -= colCounter;
                    row -= rowCounter;
                }
                else
                {
                    row++;
                    col++;
                }
                counter++;
            }
        }
        for (int row = 0; row < matrixC.GetLength(0); row++)
        {
            for (int col = 0; col < matrixC.GetLength(1); col++)
            {
                Console.Write("{0} ", matrixC[row, col]);
            }
            Console.WriteLine();
        }
    }
}
