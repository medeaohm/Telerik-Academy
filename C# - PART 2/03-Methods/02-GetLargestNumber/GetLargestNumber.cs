//### Problem 2. Get largest number
//*	Write a method `GetMax()` with two parameters that returns the larger of two integers.
//*	Write a program that reads `3` integers from the console and prints the largest of them using the method `GetMax()`.

using System;

    class GetLargestNumber
    {
        static void Main()
        {
            Console.WriteLine("Please insert 2 integer numbers...");
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int b = int.Parse(Console.ReadLine());

            GetMax(a, b);
        }

        private static void GetMax(int number1, int number2)
        {
            int greaterNum = number1;
            if (number2 > greaterNum)
            {
                greaterNum = number2;
            }
            Console.WriteLine("The grater number is --> {0}", greaterNum);
        }
    }


