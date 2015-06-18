using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Patterns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];


        for (int row = 0; row < n; row++)
        {
            string ro = Console.ReadLine();
            string[] r = ro.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < n; col++)
            {
                matrix[row,col] = int.Parse(r[col]);
            }
        }
        //for (int row = 0; row < n; row++)
        //{
        //    for (int col = 0; col < n; col++)
        //    {
        //        Console.Write(matrix[row,col]);
        //        Console.Write(" ");
        //    }
        //    Console.WriteLine();
        //}

        if (PatternFind(matrix))
        {
            Console.Write("YES ");
            int maxPattern = MaxSumPattern(matrix);
            Console.Write(maxPattern);
            Console.WriteLine();
        }
        else
        {
            Console.Write("NO ");
            int sumDiagonal = SumDiagonal(matrix);
            Console.Write(sumDiagonal);
            Console.WriteLine();
        }
        
    }

    private static int SumDiagonal(int[,] matrix)
    {
        int j = 0;
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            j++;
        }
        return sum;
    }

    private static int MaxSumPattern(int[,] matrix)
    {
        int sum = 0;
        int maxSum = 0;
        for (int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 4; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1] - 1 &&
                   matrix[i, j + 1] == matrix[i, j + 2] - 1 &&
                   matrix[i, j + 2] == matrix[i + 1, j + 2] - 1 &&
                   matrix[i + 1, j + 2] == matrix[i + 2, j + 2] - 1 &&
                   matrix[i + 2, j + 2] == matrix[i + 2, j + 3] - 1 &&
                   matrix[i + 2, j + 3] == matrix[i + 2, j + 4] - 1)
                {
                    sum = (matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j + 2] +
                   matrix[i + 2, j + 2] + matrix[i + 2, j + 3] + matrix[i + 2, j + 4]);
                }
                else
                {
                    sum = 0;
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    sum = 0;
                }
            }
        }
        return maxSum;
    }

    private static bool PatternFind(int[,] matrix)
    {
        bool pattern = false;
        for (int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1)-4; j++)
            {
                if (matrix[i,j] == matrix[i, j+1] - 1 &&
                    matrix[i,j+1] == matrix[i,j+2] - 1 &&
                    matrix[i, j+2] == matrix [i+1, j+2] - 1 &&
                    matrix [i+1, j+2] == matrix [i+2,j+2] - 1 &&
                    matrix[i+2,j+2] == matrix[i+2, j+3] - 1 &&
                    matrix[i+2, j+3] == matrix[i+2, j+4] -1)
                {
                    pattern = true;
                    break;
                }
            }
        }
        return pattern;
    }
}

