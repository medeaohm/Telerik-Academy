/*### Problem 5. Parse tags
*	You are given a text. Write a program that changes the text in all regions surrounded by the tags `<upcase>` and `</upcase>` to upper-case.
*	The tags cannot be nested.

_Example:_ We are living in a `<upcase>`yellow submarine`</upcase>`. We don't have `<upcase>`anything`</upcase>` else.

_The expected result:_ We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

using System;
using System.Text;
using System.Text.RegularExpressions;

class ParseTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine("Before Parsing:\n {0}\n\n", text);

        string parsed = Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper());
        Console.WriteLine("After Parsing:\n {0}\n\n", parsed);
    }
}