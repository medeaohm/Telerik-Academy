//7. Write a program that finds in given array of integers(all belonging to the range[0..1000]) how many times each of them occurs.
//  - Example: `array = {3, 4, 4, 2, 3, 3, 4, 3, 2}`
//    - 2 &rarr; 2 times
//    - 3 &rarr; 4 times
//    - 4 &rarr; 3 times


using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
        Console.WriteLine("Initial Sequence");
        Console.WriteLine(string.Join(", ", numbers));

        Dictionary<int, int> occurences = CountOccurances(numbers);
        Console.WriteLine("Occurences:");
        foreach (var num in occurences)
        {
            Console.WriteLine("{0} occurs {1}", num.Key, num.Value);
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

