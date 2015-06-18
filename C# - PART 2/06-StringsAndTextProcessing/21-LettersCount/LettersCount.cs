/*### Problem 21. Letters count
*	Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. */

using System;
using System.Collections.Generic;
using System.Linq;


class LettersCount
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        char[] letters = Console.ReadLine().ToCharArray();

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
        Console.WriteLine("\nLetter occurence table:\n{0}\n",
        string.Join("\n", dict.Select(x => string.Format(@"'{0}' -> {1} time(s)", x.Key, x.Value)).ToArray()));
    }
}