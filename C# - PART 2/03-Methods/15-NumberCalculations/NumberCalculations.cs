//### Problem 15.* Number calculations
//*	Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//*	Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


class NumberCalculations
{
    static void Main()
    {
        Console.WriteLine("Please choice the variables type");
        Console.WriteLine("1 --> integer");
        Console.WriteLine("2 --> double");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1": int[] array = CreateSequence(); 
                Console.WriteLine("The sequences entered is:\n{0}\n", String.Join(", ", array));
                Console.WriteLine("The minimum value of the sequence is --> Min = {0}", Min(array));
                Console.WriteLine("The maxumum value of the sequence is --> Max = {0}", Max(array));
                Console.WriteLine("The sum of the sequence is --> Sum = {0}", Sum(array));
                Console.WriteLine("The average of the sequence is --> Average = {0}", Average(array));
                Console.WriteLine("The product of the sequence is --> Product = {0}", Product(array));
                break;
            case "2": double[] arrayD = CreateSequenceD(); 
                Console.WriteLine("The sequences entered is:\n{0}\n", String.Join(", ", arrayD));
                Console.WriteLine("The minimum value of the sequence is --> Min = {0}", Min(arrayD));
                Console.WriteLine("The maxumum value of the sequence is --> Max = {0}", Max(arrayD));
                Console.WriteLine("The sum of the sequence is --> Sum = {0}", Sum(arrayD));
                Console.WriteLine("The average of the sequence is --> Average = {0}", Average(arrayD));
                Console.WriteLine("The product of the sequence is --> Product = {0}", Product(arrayD));
                break;
            default: Console.WriteLine("Invald input!");
                break;
        }
    }
    
    static int[] CreateSequence()
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

    static double[] CreateSequenceD()
    {
        Console.Write("Please insert the number of numbers in the sequence... N = ");
        int size = int.Parse(Console.ReadLine());

        while (size == 0)
        {
            Console.WriteLine("Sequence should be not empty. \nPlease insert the number of numbers in the sequence... N = ");
            size = int.Parse(Console.ReadLine());
        }

        double[] sequence = new double[size];

        Console.WriteLine("Please insert the numbers of the sequence.");

        for (int i = 0; i < size; i++)
        {
            Console.Write("Number {0} = ", i + 1);
            sequence[i] = double.Parse(Console.ReadLine());
        }
        return sequence;
    }

    static K Max<K>(params K[] array) where K : IComparable<K>
    {
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CompareTo(array[index]) == 1)
            {
                index = i;
            }
        }
        return array[index];
    }

    static K Min<K>(params K[] array) where K : IComparable<K>
    {
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CompareTo(array[index]) == -1)
            {
                index = i;
            }
        }
        return array[index];
    }

    static K Sum<K>(params K[] array) where K : IComparable<K>
    {
        return array.Aggregate<K, dynamic>(0, (current, t) => current + t);
    }

    static K Average<K>(params K[] array) where K : IComparable<K>
    {
        dynamic average = array.Aggregate<K, dynamic>(0, (current, t) => current + t);
        return average / array.Length;
    }

    static K Product<K>(params K[] array) where K : IComparable<K>
    {
        return array.Aggregate<K, dynamic>(1, (current, t) => current * t);
    }
}
