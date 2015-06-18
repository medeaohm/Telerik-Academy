//### Problem 5. Maximal area sum
//*	Write a program that reads a text file containing a square matrix of numbers.
//*	Find an area of size `2 x 2` in the matrix, with a maximal sum of its elements.
//    *	The first line in the input file contains the size of matrix `N`.
//    *	Each of the next `N` lines contain `N` numbers separated by space.
//    *	The output should be a single number in a separate text file.

//_Example:_

//| input | output |
//|-------|--------|
//| 4     |        |
//|2 3 3 4|        |
//|0 2 3 4|   17   |
//|3 7 1 2|        |
//|4 3 3 2|        |

using System;
using System.Text;
using System.IO;


class MaximalAreaSum
{
    static void Main()
    {
        StreamReader matrix = new StreamReader(@"..\..\matrix.txt");
        Console.WriteLine("Reading the text file \"matrix.txt\"... \n");
        using (matrix)
        {
            string line = matrix.ReadLine();
            int dim = int.Parse(line);
            int[,] matr = new int[dim, dim];

            for (int i = 0; i < dim; i++)
            {
                line = matrix.ReadLine();
                string[] elements = line.Split(' ');
                for (int j = 0; j < dim; j++)
                {
                    matr[i, j] = int.Parse(elements[j]);
                }
            }
            Console.WriteLine("The matrix readed from the file is: \n");
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    Console.Write(matr[i, j]);
                }
                Console.WriteLine();
            }

            int maxSum = MaxSum2x2(matr);
            Console.WriteLine("\nThe maximal sum is: {0}", maxSum);

            StreamWriter output = new StreamWriter(@"..\..\MaxSum.txt");
            output.WriteLine(maxSum);
            output.Close();

            Console.WriteLine("--> The output is saved in the file: \"MaxSum.txt\"\n");
        }  
    }

    private static int MaxSum2x2(int[,] matrix)
    {
        int maxSum = 0;
        int currentSum = 0; 
        int dim = (int)Math.Sqrt(matrix.Length);

            for (int row = 0; row < dim - 1; row++)
            {
                for (int col = 0; col < dim - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        currentSum = 0;
                    }
                }
            }
        return maxSum;
    } 
}
