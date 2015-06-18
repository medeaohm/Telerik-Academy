using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var input = new List<string>();
        for (int i = 0; i < n; i++)
        {
            input.Add(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            string currentWord = input[i];
            int newIndex = currentWord.Length % (n + 1);

            input[i] = null;
            input.Insert(newIndex, currentWord);
            input.Remove(null);
        }

        var output = new StringBuilder();
        var longestWord = 0;
        foreach (var word in input)
        {
            longestWord = Math.Max(longestWord, word.Length);
        }
        for (int i = 0; i < longestWord; i++)
        {
            foreach (var word in input)
            {
                if (word.Length > i)
                {
                    output.Append(word[i]);
                }
            }
        }
        Console.WriteLine(output.ToString());
    }
}

