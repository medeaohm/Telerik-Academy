using System;

//### Problem 9.	Sum of n Numbers
//*	Write a program that enters a number `n` and after that enters more `n` numbers and calculates and prints their `sum`.
//_Note: You may need to use a for-loop._

//_Examples:_

//| numbers | sum |
//|---------|-----|
//| 3       | 90  |
//| 20      |     |
//| 60      |     |
//| 10      |     |
//| 5       | 6.5 |
//| 2       |     |
//| -1      |     |
//| -0.5    |     |
//| 4       |     |
//| 2       |     |
//| 1       | 1   |
//| 1       |     |


class SumOfN
    {
        static void Main()
        {
            Console.WriteLine("Please insert a integer number...");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Now you have to enter {0} numbers", n);
            float b_i = 0;
            for (int i = 1; i < n + 1; i++)
            {
                Console.WriteLine("Enter a number...");
                float b = float.Parse(Console.ReadLine());
                b_i = b_i + b;
            }
            Console.WriteLine("\nThe sum of the entered numbers is... {0}", b_i);
        }
    }

