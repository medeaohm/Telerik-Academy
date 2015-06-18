/*### Problem 4. Sub-string in text
*	Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

_Example:_

The target sub-string is `in`

The text is as follows:
We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: `9`*/
using System;
using System.Linq;

class SubStringInText
{
    static void Main()
    {
        Console.WriteLine("Please enter a text: ");
        string text = Console.ReadLine();

        Console.WriteLine("\nPlease enter the sub-string to find: ");
        string substring = Console.ReadLine();

        int count = text.Select((c, i) => text.Substring(i)).Count(sub => sub.StartsWith(substring));
        Console.WriteLine("\nThe substring \"{0}\" appears {1} times in the text", substring, count);
    }
}