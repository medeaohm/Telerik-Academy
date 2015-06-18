namespace MatrixClass
{
    using System;

    class TestMatrix
    {
        public static void Main(string[] args)
        {
            var matrix = new Matrix<int>(5, 5);
            var matrix2 = new Matrix<int>(5, 5);
            var matrix3 = new Matrix<int>(5, 5);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    matrix[i, j] = i + j;
                    matrix2[i, j] = i - j;
                    //matrix3[i, j] = 0;
                }
            }
            Console.WriteLine("First matrix:\n{0}",matrix.ToString());
            Console.WriteLine("Second matrix:\n{0}", matrix2.ToString());
            Console.WriteLine("Third matrix:\n{0}", matrix3.ToString());

            var sumMatrix = matrix + matrix2;
            var diffMatrix = matrix - matrix2;
            var productMatrix = matrix * matrix2;

            Console.WriteLine("Sum:\n{0}", sumMatrix.ToString());
            Console.WriteLine("Difference:\n{0}", diffMatrix.ToString());
            Console.WriteLine("Product:\n{0}", productMatrix.ToString());

            if (matrix3)
            {
                Console.WriteLine("The third matrix has all the elements equal to zero");
            }
            if (matrix2)
            {
                Console.WriteLine("Not all the elementns of the second matrix are equal to zero");
            }
        }
    }
}
