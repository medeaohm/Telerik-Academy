using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IncreasingAbsoluteDifferences
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        string[] result = new string[t];
        for (int i = 0; i < t; i++)
        {
            string input = Console.ReadLine();
            string[] inputNumbersString = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] inputNumbers = new int[inputNumbersString.Length];
            for (int j = 0; j < inputNumbersString.Length; j++)
            {
                inputNumbers[j] = int.Parse(inputNumbersString[j]);
            }

            List<int> abs = AbsoluteDifferences(inputNumbers);
            bool increasing = IsIncreasingSequence(abs);
            if (increasing)
            {
                result[i] = "True";
            }
            else
            {
                result[i] = "False";
            }
        }
        for (int i = 0; i < t; i++)
        {
            Console.WriteLine(result[i]);
        }
    }

    private static bool IsIncreasingSequence(List<int> abs)
    {
        
        for (int i = abs.Count-1; i > 0; i--)
        {
            if (abs[i] - abs[i-1] >= 0 & abs[i] - abs[i-1] <= 1)
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

    private static List<int> AbsoluteDifferences(int[] inputNumbers)
    {
        var abs = new List<int>();
        int diff = 0;
        for (int i = 0; i < inputNumbers.Length - 1; i++)
        {
            if (inputNumbers[i + 1] > inputNumbers[i]) 
            {
                diff = inputNumbers[i + 1] - inputNumbers[i];
            }
            else
            {
                diff = inputNumbers[i] - inputNumbers[i+1];
            }
            abs.Add(diff);
        }
        return abs;
    }
}

