/*### Problem 20. Palindromes
*	Write a program that extracts from a given text all palindromes, e.g. `ABBA`, `lamal`, `exe`.*/

using System;
using System.Text;

class Palindromes
{
    static readonly char[] separators = new char[] { ' ', '\t', ',', '!', '?', ';', '(', ')', '{', '}', '[', ']', '\n', '.' };

    static void Main()
    {
        Console.WriteLine("Please enter some text: ");
        //string text = Console.ReadLine();       
        string text = "abba lamal,joy: monday exe.";
        Console.WriteLine(text);
        text.ToLower();

        string[] splitted = text.Split(separators);
        StringBuilder palindromes = new StringBuilder();

        foreach (string word in splitted)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == word[word.Length - 1 - i])
                {
                    if (i == word.Length / 2)
                    {
                        palindromes.Append(word);
                        palindromes.Append(" ");
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        string[] pal = palindromes.ToString().Split(' ');
        if (pal.Length == 0)
        {
            Console.WriteLine("\nPalindromes not found in the given text");
        }
        else
        {
            Console.WriteLine("\nThe palindromes found in the given text are: ");
            foreach (string word in pal)
            {
                Console.WriteLine(word);
            }
        }
    }
}
