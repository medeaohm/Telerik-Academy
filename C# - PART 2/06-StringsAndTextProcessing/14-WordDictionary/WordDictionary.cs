//### Problem 14. Word dictionary
//*	A dictionary is stored as a sequence of text lines containing words and their explanations.
//*	Write a program that enters a word and translates it by using the dictionary.

//_Sample dictionary:_

//|   input   |                  output                  |
//|:---------:|:----------------------------------------:|
//| .NET      | platform for applications from Microsoft |
//| CLR       | managed execution environment for .NET   |
//| namespace | hierarchical organization of classes     |

using System;
using System.Text;


class WordDictionary
{
    static void Main()
    {
        string[,] dictionary = 
        {
        {".NET" , "platform for applications from Microsoft"},
        {"CLR" , "managed execution environment for .NET"},
        {"namespace", "hierarchical organization of classes"}
        };

        Console.Write("Please insert a word: ");
        string word = Console.ReadLine();

        string output = "Not found!";

        for (int i = 0; i < dictionary.GetLength(0); i++)
        {
            if (word == dictionary[i, 0])
            {
                output = dictionary[i, 1];
                break;
            }
        }
        Console.WriteLine("\n{0} - {1}\n", word, output);
    }
}

