/*### Problem 8. Extract sentences
*	Write a program that extracts from a given text all sentences containing given **word**.

_Example:_

_The word is:_ **in**

_The text is:_ We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

_The expected result is:_ We are living in a yellow submarine. We will move out of it in 5 days.

_Consider that the sentences are separated by `.` and the words ? by **non-letter symbols**._*/

using System;
using System.Text;
using System.Linq;


class ExtractSentences
{
      
    static void Main()
    {
        
        Console.WriteLine("Please insert a text: ");
        string text = Console.ReadLine();

        Console.WriteLine("\nPlease insert a word to search: ");
        string word =  Console.ReadLine();

        char[] symbols = { '.', ' ', '?', '!', ':', ';', '\n', '\t'};
        string[] key = new string[symbols.Length];
        for (int i = 0; i < symbols.Length; i++)
        {
            key[i] = " " + word + symbols[i];
        }
      
        string[] sentences = text.Split('.');
        int count = 0;
        Console.WriteLine("\nThe sentences wich contains the word \"{0}\" are:", word);
        for (int i = 0; i < sentences.Length; i++)
        {
            bool present = false;
            
            for (int j = 0; j < key.Length; j++)
            {
                if (sentences[i].Contains(key[j]) | sentences[i].Contains(" " + word))
                {
                    present = true;
                } 
            }
            if (present)
            {
                count++;
                Console.Write("{0}. ", sentences[i]);
            }  
        }
        if (count == 0)
        {
            Console.WriteLine("There are no sentences int the text containing the word \"{0}\"!", word);
        }
        Console.WriteLine("\n");
    }
}