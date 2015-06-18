/*	### Problem 22. Words count
*	Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found. */

using System;
using System.Collections.Generic;
using System.Linq;


class WordsCount
{
    static readonly char[] separators = new char[] { ' ', '\t', ',', '!', '?', ';', '(', ')', '{', '}', '[', ']', '\n' };

    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (!dict.ContainsKey(word))
            {
                dict.Add(word, 1);
            }
            else
            {
                dict[word]++;
            }
        }
        Console.WriteLine("\nWord occurence table:\n{0}\n",
        string.Join("\n", dict.Select(x => string.Format(@"'{0}' -> {1} time(s)", x.Key, x.Value)).ToArray()));
    }
}
