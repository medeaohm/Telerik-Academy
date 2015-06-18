//### Problem 3. Sequence n matrix
//*	We are given a matrix of strings of size `N x M`. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.

//_Example:_

//| matrix        |   result   |   | matrix   | result  |
//|:-------------:|:----------:|:-:|:--------:|:-------:|
//| ha fifi ho hi | ha, ha, ha |   | s  qq  s | s, s, s |
//| fo  ha  hi xx |            |   | pp pp  s |         |
//| xxx ho  ha xx |            |   | pp qq  s |         |


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SequenceMatrix
{
    static void Main()
    {
        Console.WriteLine("We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal. This program finds the longest sequence of equal strings in the matrix. \n");

        Console.WriteLine("Please insert matrix size...");
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Element [{0},{1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

/* ----------------- MATRIX FOR TESTING -> COMMENT ABOVE AND UNCOMMENT ONE OF THE MATRIX BELOW ----------------------- */

        //string[,] matrix = 
        //{
        //    {"ha", "fifi", "ho", "hi"},
        //    {"fo", "ha", "hi", "xx"},
        //    {"xxx", "ho", "ha", "xx"}
        //};

        //string[,] matrix = 
        //{
        //    {"ha", "ha", "ha", "ha"},
        //    {"fo", "ha", "hi", "xx"},
        //    {"xxx", "ho", "ha", "xx"}
        //};

/*----------------------------------------------------------------------------------------------------------------------*/

        int countD = 0;
        int countR = 0;
        int countC = 0;
        int maxCount = 0;
        string res = "";
        string compare = "";


        // diagonal
        for (int row = 0; row < matrix.GetLength(0) ; row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                countD = 1;
                compare = matrix[row, col];
                for (int k = row +1, l = col+1; (k < matrix.GetLength(0)) && (l < matrix.GetLength(1)); k++, l++)
                {
                    if (matrix[k, l] == compare)
                    {
                        countD++;
                    }
                    if (maxCount < countD)
                    { 
                        maxCount = countD;
                        res = compare;
                    }
                }
            }
        }


        // vertical
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) ; col++)
            {
                countC = 1;
                compare = matrix[row, col];
                for (int k = row+1; k < matrix.GetLength(0); k++)
                {
                    if (matrix[k, col] == compare)
                    {
                        countC++;
                    }
                    if (maxCount < countC)
                    {
                        maxCount = 0;
                        maxCount = countC;
                        res = compare;
                    }
                }
            }
        }

        // horizontal
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                compare = matrix[row, col];
                countR = 1;
                for (int k = col + 1; k < matrix.GetLength(1); k++)
                {
                    if (matrix[row, k] == compare)
                    {
                        countR++;
                    }
                    if (maxCount < countR)
                    {
                        maxCount = 0;
                        maxCount = countR;
                        res =compare;
                    }
                }
            }
        }

        string[] final = new string[maxCount];
        for (int i = 0; i < maxCount; i++)
        {  
            final[i] = res;  
        }

        Console.Write("{0} ", String.Join(", ", final));
        Console.WriteLine();
    }
}
