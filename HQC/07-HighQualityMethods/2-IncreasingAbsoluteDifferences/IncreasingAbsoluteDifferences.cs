using System;
using System.Collections.Generic;

public class IncreasingAbsoluteDifferences
{
    public static void Main()
    {
        int numberOfSequences = int.Parse(Console.ReadLine());
        string[] output = new string[numberOfSequences];

        for (int i = 0; i < numberOfSequences; i++)
        {
            int[] numbersOfTheSequence = ReadInput();
            List<int> absoluteDifferences = AbsoluteDifferences(numbersOfTheSequence);
            bool isIncreasing = IsSequenceIncreasing(absoluteDifferences);
            
            if (isIncreasing)
            {
                output[i] = "True";
            }
            else
            {
                output[i] = "False";
            }
        }

        PrintOutput(numberOfSequences, output);
    }

    private static int[] ReadInput()
    {
        string sequence = Console.ReadLine();
        string[] numbersOfTheSequenceAsString = sequence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbersOfTheSequence = new int[numbersOfTheSequenceAsString.Length];

        for (int j = 0; j < numbersOfTheSequenceAsString.Length; j++)
        {
            numbersOfTheSequence[j] = int.Parse(numbersOfTheSequenceAsString[j]);
        }
        return numbersOfTheSequence;
    }

    private static List<int> AbsoluteDifferences(int[] numbers)
    {
        var absoluteDifferences = new List<int>();
        int difference = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i + 1] > numbers[i])
            {
                difference = numbers[i + 1] - numbers[i];
            }
            else
            {
                difference = numbers[i] - numbers[i + 1];
            }

            absoluteDifferences.Add(difference);
        }

        return absoluteDifferences;
    }

    private static bool IsSequenceIncreasing(List<int> absoluteDifference)
    {        
        for (int i = absoluteDifference.Count - 1; i > 0; i--)
        {
            bool isLargerThanPrevious = absoluteDifference[i] - absoluteDifference[i - 1] >= 0;
            bool isLargerThanNext = absoluteDifference[i] - absoluteDifference[i - 1] <= 1;
            bool isLargerThanNeighbours = isLargerThanPrevious && isLargerThanNext;
            
            if (isLargerThanNeighbours)
            {             
                continue;
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    private static void PrintOutput(int numberOfSequences, string[] output)
    {
        for (int i = 0; i < numberOfSequences; i++)
        {
            Console.WriteLine(output[i]);
        }
    }
}