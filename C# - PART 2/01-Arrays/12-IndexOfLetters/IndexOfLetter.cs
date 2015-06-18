//### Problem 12. Index of letters
//*	Write a program that creates an array containing all letters from the alphabet (`A-Z`).
//*	Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;

class IndexOfLetter
{
    static void Main()
    {
        char[] lettersC = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        List<char> letterC = new List<char>();
        for (int i = 0; i < lettersC.Length; i++)
        {
            letterC.Add(lettersC[i]);
        }

        char[] lettersS = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        List<char> letterS = new List<char>();
        for (int i = 0; i < lettersS.Length; i++)
        {
            letterS.Add(lettersS[i]);
        }


        Console.WriteLine("Please insert a word...");
        string word = Console.ReadLine();
        char[] w = word.ToCharArray();
        for (int i = 0; i < w.Length; i++)
        {
            if (letterC.IndexOf(w[i]) != -1)
            {
                Console.WriteLine("The index of {0} is {1}", w[i], letterC.IndexOf(w[i]));
            }
            else if (letterS.IndexOf(w[i]) != -1)
            {
                Console.WriteLine("The index of {0} is {1}", w[i], letterS.IndexOf(w[i]));
            }
            else
            {
                Console.WriteLine("Not a word...");
            }
        } 
    }
}

