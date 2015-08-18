namespace Rotating_Walk_in_Matrix
{
    using System;

    public class MatrixMain
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int size = 0;

            while (!int.TryParse(input, out size) || size <= 0 || size > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            Matrix matrix = new Matrix(size);
            Console.WriteLine(matrix);
        }
    }
}
