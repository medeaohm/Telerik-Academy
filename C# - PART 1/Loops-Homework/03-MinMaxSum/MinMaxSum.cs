using System;
using System.Linq;

//### Problem 3.	Min, Max, Sum and Average of N Numbers
//*	Write a program that reads from the console a sequence of `n` integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//*	The input starts by the number `n` (alone in a line) followed by `n` lines, each holding an integer number.
//*	The output is like in the examples below.



//_Example 2:_

//| input | output     |
//|-------|------------|
//| 2     | min = -1   |
//| -1    | max = 4    |
//| 4     | sum = 3    |
//|       | avg = 1.50 |


class MinMaxSum
    {
        static void Main()
        {
            Console.WriteLine("Please insert a positive integer number...");
            int n = int.Parse(Console.ReadLine());
            double[] numbers;
            numbers = new double[n];
            
            for (int i = 0; i < n; i++)
			{
			    double j = double.Parse(Console.ReadLine());
                numbers[i] = j; 
			}

            double sum = numbers.Sum();
            double min = numbers.Min();
            double max = numbers.Max();
            double average = numbers.Average();

            Console.WriteLine(" min = {0} \n max = {1} \n sum = {2} \n average = {3:0.00}", min, max,sum,average);

        }
    }
