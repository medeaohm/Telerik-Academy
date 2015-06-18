//### Problem 10. Unicode characters
//*	Write a program that converts a string to a sequence of C# Unicode character literals.
//*	Use format strings.

//_Example:_

//| input |       output       |
//|:-----:|:------------------:|
//| Hi!   | \u0048\u0069\u0021 |

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main(string[] args)
    {
        Console.Write("Please enter some text: ");
        string text = Console.ReadLine();

        Console.WriteLine(ParseToUnicode(text));
    }

    private static string ParseToUnicode(string text)
    {
        StringBuilder result = new StringBuilder();

        Console.WriteLine("Unicode: ");
        foreach (var letter in text)
        {
            result.Append(String.Format("\\u{0:X4}", (int)letter));
        }

        return result.ToString();
    }
}
