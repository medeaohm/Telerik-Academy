//### Problem 9.	Matrix of Numbers
//*	Write a program that reads from the console a positive integer number `n` (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.

//_Examples:_

//    n = 2	matrix		n = 3	matrix		n = 4	matrix
//            1 2				1 2 3		        1 2 3 4
//            2 3				2 3 4			    2 3 4 5
//                              3 4 5				3 4 5 6
//                                                  4 5 6 7

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Please, enter a whole positive number in the range [1...20], N = ");
        string numberStr = Console.ReadLine();
        int numN = int.Parse(numberStr);
        if (numN < 1 || numN > 20)
        {
            Console.WriteLine("Error - Invalid Number !!!");
        }
        else
        {
            Console.WriteLine("The matrix of numbers is:");
            Console.WriteLine();
            for (int i = 1; i <= numN; i++)
            {
                for (int j = i; j < numN + i; j++)
                {
                    Console.Write("{0,2} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
