using System;

//### Problem 8.	Square Root
//*	Create a console application that calculates and prints the square root of the number `12345`.
//*	Find in Internet “how to calculate square root in C#”.

class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("The square root of 12345 is...");
        double SqrtNumber = Math.Sqrt(12345);
        Console.WriteLine(SqrtNumber);
    }
}
