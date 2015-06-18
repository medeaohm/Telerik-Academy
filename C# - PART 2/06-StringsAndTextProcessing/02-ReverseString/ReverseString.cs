/*### Problem 2. Reverse string
*	Write a program that reads a string, reverses it and prints the result at the console.

_Example:_

|  input | output |
|:------:|:------:|
| sample | elpmas |*/

using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Please enter a string...");
        string str = Console.ReadLine();
        string reverse = new string (str.Reverse().ToArray());

        Console.WriteLine("The reversed string is: {0}", reverse);
    }
}