//### Problem 13. Reverse sentence
//*	Write a program that reverses the words in given sentence.

//_Example:_

//|                   input                  |                  output                  |
//|:----------------------------------------:|:----------------------------------------:|
//| `C# is not C++, not PHP and not Delphi!` | `Delphi not and PHP, not C++ not is C#!` |


using System;
using System.Text;

class ReverseSentence
{
   

    static void Main()
    {
        char[] separators = { ' ', '?', '!', '.', ';', '-', '/', ',' };
        Console.WriteLine("Please insert a sentence: ");
        string text = Console.ReadLine();
        //string text = "C# is not C++, not PHP and not Delphi!";
        char lastSymbol = text[text.Length - 1];


        string[] splitted = text.Split(separators);
        string reversed=null;
        for (int i = splitted.Length-1; i >=0 ; i--)
        {
            reversed = reversed + splitted[i]+ " ";
        }
        Console.WriteLine("\nThe reversed sentence is:");
        Console.WriteLine(reversed.Trim()+lastSymbol);
    }
}

