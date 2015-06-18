using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class FeaturingWithGrisko
{
    static void Main()
    {
        string input = Console.ReadLine().ToUpper();

        int maxOccurrence = FindMaxOccurrence(input);
        var uniques = new List<string>();
        uniques.Add(input[0].ToString());
        foreach (char ch in input)
        {
            if (uniques.Contains(ch.ToString()))
            {
                continue;
            }
            else
            {
                uniques.Add(ch.ToString());
            }
        }

        BigInteger combination = 1;
        if (maxOccurrence * uniques.Count > input.Length+1)
        {
            combination = 0;
        }
        else if (maxOccurrence * uniques.Count == input.Length+1)
        {
            for (int i = 1; i < uniques.Count; i++)
            {
                combination *= i;
            }
        }
        else
        {
            for (int i = 1; i < uniques.Count + 1; i++)
            {
                combination *= i;
            }
        }
        Console.WriteLine(combination); 
    }

    private static int FindMaxOccurrence(string input)
    {
        char[] letters = input.ToCharArray();

        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (char character in letters)
        {
            if (!dict.ContainsKey(character))
            {
                dict.Add(character, 1);
            }
            else
            {
                dict[character]++;
            }
        }
        //dict.Keys.Max()
        return dict.Values.Max();
    }    
}

