using System;

public class Cube3D
{
    public static void Main()
    {
        int cubeDimension = int.Parse(Console.ReadLine());
        string colon = ":";
        string verticalLine = "|";
        string minus = "-";

        // sorry for this 
        int a0 = 1;
        int b0 = 1;
        int a = cubeDimension;
        int b = cubeDimension;
        int c = cubeDimension;

        for (int row = 0; row < (2 * cubeDimension) - 1; row++)
        {
            Console.WriteLine(string.Empty);

            for (int col = 0; col < (2 * cubeDimension) - 1; col++)
            {
                bool inCube = row < cubeDimension && col < cubeDimension;
                bool rowInCubeColOutsideCube = row < cubeDimension && col >= cubeDimension;
                bool colInCubeRowOutsideCube = row >= cubeDimension && col < cubeDimension;
                bool colOutsideCubeRowOutsideCube = row >= cubeDimension && col >= cubeDimension;

                if (inCube)
                {
                    DrawInternalCube(cubeDimension, colon, row, col);
                }
                else if (rowInCubeColOutsideCube)
                {
                    DrawRowOutsideColInside(colon, verticalLine, ref a0, ref a, row, col);
                }
                else if (colInCubeRowOutsideCube)
                {
                    DrawColOutsideRowInside(colon, minus, ref b0, ref b, row, col);
                }
                else if (colOutsideCubeRowOutsideCube)
                {
                    DrawColOutsideRowOutside(cubeDimension, colon, verticalLine, minus, ref c, row, col);
                }
            }
        }
    }

    // I've tried to do my best - but this methods are magical and the deadline of the homework is coming
    private static void DrawColOutsideRowOutside(
        int cubeDimension, string colon, string verticalLine, string minus, ref int c, int row, int col)
    {
        if (col == (2 * cubeDimension) - 2)
        {
            Console.Write(colon);
        }
        else if (row == (2 * cubeDimension) - 2 & (col < (2 * cubeDimension) - 2))
        {
            Console.Write(colon);
        }
        else if (col == c & row == c)
        {
            Console.Write(colon);
            c++;
        }
        else if (row > c - 2 & col > c - 1 & col < (2 * cubeDimension) - 2)
        {
            Console.Write(verticalLine);
        }
        else
        {
            Console.Write(minus);
        }
    }

    private static void DrawColOutsideRowInside(string colon, string minus, ref int b0, ref int b, int row, int col)
    {
        if (row == b & col == b0)
        {
            Console.Write(colon);
            b++;
            b0++;
        }
        else if (row > b - 2 & col > b0 - 1)
        {
            Console.Write(minus);
        }
        else
        {
            Console.Write(" ");
        }
    }

    private static void DrawRowOutsideColInside(string colon, string verticalLine, ref int a0, ref int a, int row, int col)
    {       
        if (row == a0 & col == a)
        {
            Console.Write(colon);
            a++;
            a0++;
        }
        else if (row > a0 - 1 & col < a)
        {
            Console.Write(verticalLine);
        }
    }

    private static void DrawInternalCube(int cubeDimension, string colon, int row, int col)
    {
        bool border = row == 0 || row == cubeDimension - 1 || col == 0 || col == cubeDimension - 1;
        bool intern = col < cubeDimension - 1 && col > 0;

        if (border)
        {
            Console.Write(colon);
        }
        else if (intern)
        {
            Console.Write(" ");
        }
    }
}