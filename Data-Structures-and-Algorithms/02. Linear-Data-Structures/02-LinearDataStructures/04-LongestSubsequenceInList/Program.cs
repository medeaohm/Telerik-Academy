//4. Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new `List<int>`.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a sequence of numbers separated with a space");

        var input = Console.ReadLine();

        var longestSequence = FindLongestSusequnce(input);

        Console.WriteLine("Longest sequence:");
        foreach (var num in longestSequence)
        {
            Console.Write(num + " ");
        }
    }

    public static List<int> FindLongestSusequnce(string input)
    {
        var splittedInput = input.Split(' ');

        List<int> longestSequence = new List<int>();
        List<int> inputList = new List<int>();

        inputList.Add(int.Parse(splittedInput[0]));
        var resultNumber = inputList[0];
        var currentNumber = inputList[0];
        var maxOccurances = 0;
        var currentOccurances = 1;
        var endIndex = 0;

        for (int i = 1; i < splittedInput.Length; i++)
        {
            inputList.Add(int.Parse(splittedInput[i]));

            if (inputList[i] == currentNumber)
            {
                currentOccurances++;
                endIndex = i + 1;
            }
            else
            {
                if (currentOccurances > maxOccurances)
                {
                    maxOccurances = currentOccurances;
                    resultNumber = currentNumber;
                    currentOccurances = 1;
                }
            }

            currentNumber = inputList[i];
        }

        return longestSequence = inputList.GetRange(endIndex - maxOccurances, maxOccurances);
    }
}

