/*### Problem 12. Parse URL
*	Write a program that parses an URL address given in the format: `[protocol]://[server]/[resource]` and extracts from it the `[protocol]`, `[server]` and `[resource]` elements.

_Example:_ 

|                 URL                  |                                     Information                                          |
|:------------------------------------:|:----------------------------------------------------------------------------------------:|
| `http://telerikacademy.com/Courses/Courses/Details/212` | [protocol] = `http`                                                   |
|                                                         | [server] = `telerikacademy.com`                                       |
|                                                         | [resource] = `/Courses/Courses/Details/212`                           | */

using System;
using System.Text;

class ParseURL
{
    static void Main()
    {
        Console.WriteLine("Please insert a URL: ");
        string url = Console.ReadLine();

        string protocol = url.Substring(0, url.IndexOf(':'));
        string remaining = url.Substring((url.IndexOf(':') + 3));
        string server = remaining.Substring(0, remaining.IndexOf('/'));
        string resource = remaining.Substring(remaining.IndexOf('/'));

        Console.WriteLine("\n");
        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
        Console.WriteLine("\n");
    }
}
