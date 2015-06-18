/*Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***. */

using System;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Please enter a text: ");
        string text = Console.ReadLine();
        //string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        Console.WriteLine("\nPlease enter the forbidden words (on a single line separated by space): ");
        string forbidden = Console.ReadLine();
        //string forbidden = "PHP CLR Microsoft";

        string[] forWords = forbidden.Split(' ');

        string newText = text;
        string rep;

        foreach (var word in forWords)
        {
            rep = new string('*', word.Length);
            newText = newText.Replace(word, rep);
        }
       
        Console.WriteLine("\nNew text:\n {0}", newText);
    }
}