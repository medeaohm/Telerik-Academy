using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitShiftMatrix
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        ulong[,] matrix = FillTheMatrix(r, c);

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        int moves = int.Parse(Console.ReadLine());

        string code = Console.ReadLine();
        string[] codeS = code.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        ulong collected = MoveAndCollect(matrix, codeS, moves);
        Console.WriteLine(collected);
        
    }

    private static ulong MoveAndCollect(ulong[,] matrix, string[] codeS, int moves)
    {
        ulong sum = 0;
        ulong coeff = matrix[matrix.GetLength(0) - 1, 0];
        int currentRow = matrix.GetLength(0) - 1;
        int currentCol = 0;
        bool[,] visit = new bool[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < codeS.Length; i++)
        {
            ulong currentCode = ulong.Parse(codeS[i]);
            int nextRow = (int)(currentCode / coeff) % matrix.GetLength(0);
            int nextCol = (int)(currentCode % coeff) % matrix.GetLength(1);
            if (currentCol < nextCol)
            {
                for (int j = currentCol; j < nextCol; j++)
                {
                    if (!visit[currentRow, j])
                    {
                        sum += matrix[currentRow, j];
                        visit[currentRow, j] = true;
                    }   
                }
            }
            else if (currentCol > nextCol)
            {
                for (int j = currentCol; j >= nextCol; j--)
                {
                    if (!visit[currentRow, j])
                    {
                        sum += matrix[currentRow, j];
                        visit[currentRow, j] = true;
                    }
                }
            }


            if (currentRow < nextRow)
            {
                for (int j = currentRow; j < nextRow; j++)
                {
                    if (!visit[j, nextCol])
                    {
                        sum += matrix[nextCol, j];
                        visit[j, nextCol] = true;
                    }
                }
            }
            else if (currentRow > nextRow)
            {
                for (int j = currentRow; j >= nextRow; j--)
                {
                    if (!visit[j, nextCol])
                    {
                        sum += matrix[nextCol, j];
                        visit[j, nextCol] = true;
                    }
                }
            }
            currentCol = nextCol;
            currentRow = nextRow;
        }
        return sum;
    }

    private static ulong[,] FillTheMatrix(int r, int c)
    {
        ulong[,] matrix = new ulong[r, c];

        ulong exp1 = 1;
        ulong exp2 = 1;
        for (int i = r - 1; i >= 0; i--)
        {

            for (int j = 0; j < c; j++)
            {
                if (i == r - 1)
                {
                    if (j == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        exp1 *= 2;
                        matrix[i, j] = exp1;
                    }
                }
                else if (j == 0)
                {
                    exp2 *= 2;
                    matrix[i, j] = exp2;
                }
                else
                {
                    matrix[i, j] = matrix[i, j - 1] + matrix[i + 1, j];
                }
            }
        }
        return matrix;
    }
}

