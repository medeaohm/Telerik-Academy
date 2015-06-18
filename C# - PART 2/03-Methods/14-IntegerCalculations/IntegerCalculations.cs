//### Problem 14. Integer calculations
//*	Write methods to calculate `minimum`, `maximum`, `average`, `sum` and `product` of given set of integer numbers.
//*	Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Text;


class IntegerCalculations
{
    static void Main()
    {
        int[] array = CreateSequence();
        Console.WriteLine("The sequences entered is:\n{0}\n", String.Join(", ", array));
        Console.WriteLine("The minimum value of the sequence is --> Min = {0}", Min(array));
        Console.WriteLine("The maxumum value of the sequence is --> Max = {0}", Max(array));
        Console.WriteLine("The sum of the sequence is --> Sum = {0}", Sum(array));
        Console.WriteLine("The average of the sequence is --> Average = {0}", Average(array));
        Console.WriteLine("The product of the sequence is --> Product = {0}", Product(array));
    }

    private static int[] CreateSequence()
    {
        Console.Write("Please insert the number of numbers in the sequence... N = ");
        int size = int.Parse(Console.ReadLine());

        while (size == 0)
        {
            Console.WriteLine("Sequence should be not empty. \nPlease insert the number of numbers in the sequence... N = ");
            size = int.Parse(Console.ReadLine());
        }

        int[] sequence = new int[size];

        Console.WriteLine("Please insert the numbers of the sequence.");

        for (int i = 0; i < size; i++)
        {
            Console.Write("Number {0} = ", i + 1);
            sequence[i] = int.Parse(Console.ReadLine());
        }
        return sequence;
    }

    private static int Max(int[] array)
    {
        int max = Int32.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    private static int Min(int[] array)
    {
        int min = Int32.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    private static int Sum(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    private static decimal Average(int[] array)
    {
        decimal sum = 0;
        decimal size = array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        decimal average = sum / size;
        return average;
    }

    private static int Product(int[] array)
    {
        int product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }
}

