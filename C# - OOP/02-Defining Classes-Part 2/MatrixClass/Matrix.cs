namespace MatrixClass
{
    using System;
    using System.Text;

    public class Matrix<T>
    {
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public int Rows { get { return this.matrix.GetLength(0); } }

        public int Cols { get { return this.matrix.GetLength(1); } }

        public T this [int row, int col]
        {
            get
            {
                if (row < 0 || row >= this.Rows)
                {
                    throw new IndexOutOfRangeException("Row out of range!");
                }
                if (col < 0 || col >= this.Cols)
                {
                    throw new IndexOutOfRangeException("Col out of range!");
                }
                return this.matrix[row, col];
            }
            set 
            {
                if (row < 0 || row >= this.Rows)
                {
                    throw new IndexOutOfRangeException("Row out of range!");
                }
                if (col < 0 || col >= this.Cols)
                {
                    throw new IndexOutOfRangeException("Col out of range!");
                }
                this.matrix[row, col] = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    output.Append(matrix[row, col].ToString() + " ");
                }
                output.AppendLine();
            }

            return output.ToString();
        }

        public static Matrix<T> operator+(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Cols || firstMatrix.Rows != secondMatrix.Rows)
            {
                throw new InvalidOperationException("The two matrix have different sizes!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
			{
			     for (int j = 0; j < firstMatrix.Cols; j++)
			     {
                     result[i,j] = (dynamic)firstMatrix[i,j] + secondMatrix[i,j];
                 }
			}
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Cols || firstMatrix.Rows != secondMatrix.Rows)
            {
                throw new InvalidOperationException("The two matrix have different sizes!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Cols || firstMatrix.Rows != secondMatrix.Rows)
            {
                throw new InvalidOperationException("The two matrix have different sizes!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    dynamic temp = 0;

                    for (int curNum = 0; curNum < Math.Min(firstMatrix.Cols, firstMatrix.Rows); curNum++)
                    {
                        temp += (dynamic)firstMatrix[i, curNum] * (dynamic)secondMatrix[curNum, j];
                    }
                    result[i, j] = temp;
                }
            }
            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i,j] == (dynamic)0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] != (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
