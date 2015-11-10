//8. * The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
//  - Write a program to find the majorant of given array(if exists).
//  - Example:
//    - `{2, 2, 3, 3, 2, 3, 4, 3, 3}` &rarr; `3`


using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numbersWithoutMajorant = new List<int>() { 4, 2, 2, 2, 5, 3, 5, 2, 1, 5, 2 };
        List<int> numbersWithMajorant = new List<int>() { 2, 2, 2, 2, 5, 3, 5, 2, 1, 5, 2 };

        Console.WriteLine("Initial Sequence");
        Console.WriteLine(string.Join(", ", numbersWithoutMajorant));
        Dictionary<int, int> occurences = CountOccurances(numbersWithoutMajorant);
        FindMajorant(occurences, numbersWithoutMajorant.Count);


        Console.WriteLine("Initial Sequence");
        Console.WriteLine(string.Join(", ", numbersWithMajorant));
        Dictionary<int, int> occurences2 = CountOccurances(numbersWithMajorant);
        FindMajorant(occurences2, numbersWithMajorant.Count);
    }

    private static void FindMajorant(Dictionary<int, int> occurances, int arraySize)
    {
        bool majorantExist = false;
        foreach (var item in occurances)
        {
            if (item.Value >= arraySize/2 + 1)
            {
                majorantExist = true;
                Console.WriteLine("Majorant = {0}", item.Key);
            }
        }

        if (!majorantExist)
        {
            Console.WriteLine("Majorant does not exist into the array");
        }
    }

    private static Dictionary<int, int> CountOccurances(List<int> numbers)
    {
        var occurences = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (!occurences.ContainsKey(numbers[i]))
            {
                occurences.Add(numbers[i], 1);
            }
            else
            {
                occurences[numbers[i]]++;
            }
        }

        return occurences;
    }
}

