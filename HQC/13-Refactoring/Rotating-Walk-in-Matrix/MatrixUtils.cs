namespace Rotating_Walk_in_Matrix
{
    public class MatrixUtils
    {
        private const int DIRECTIONS_LENGHT = 8;
        private static readonly int[] DIRECTION_X = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private static readonly int[] DIRECTION_Y = { 1, 0, -1, -1, -1, 0, 1, 1 };

        public static void GetNextDirection(ref int dirX, ref int dirY)
        {
            int currentDirection = 0;

            for (int i = 0; i < DIRECTIONS_LENGHT; i++)
            {
                if (DIRECTION_X[i] == dirX && DIRECTION_Y[i] == dirY)
                {
                    currentDirection = i;
                    break;
                }
            }

            if (currentDirection == DIRECTIONS_LENGHT - 1)
            {
                dirX = DIRECTION_X[0];
                dirY = DIRECTION_Y[0];
                return;
            }
            else
            {
                dirX = DIRECTION_X[currentDirection + 1];
                dirY = DIRECTION_Y[currentDirection + 1];
            }
        }

        public static bool CheckIfNeighbourCellsAreEmpty(int[,] matrix, int row, int col)
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < DIRECTIONS_LENGHT; i++)
            {
                if (!IsInRange(matrix, row + directionX[i]))
                {
                    directionX[i] = 0;
                }

                if (!IsInRange(matrix, col + directionY[i]))
                {
                    directionY[i] = 0;
                }
            }

            for (int i = 0; i < DIRECTIONS_LENGHT; i++)
            {
                if (matrix[row + directionX[i], col + directionY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsInRange(int[,] matrix, int value)
        {
            if (0 <= value && value < matrix.GetLength(0))
            {
                return true;
            }

            return false;
        }

        public static void FindEmptyCell(int[,] matrix, out int emptyCellRow, out int emptyCellCol)
        {
            emptyCellRow = 0;
            emptyCellCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (matrix[row, col] == 0) 
                    { 
                        emptyCellRow = row; 
                        emptyCellCol = col; 
                        return; 
                    }
                }   
            }
        }
    }
}