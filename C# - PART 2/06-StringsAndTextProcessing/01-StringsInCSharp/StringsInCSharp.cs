/*### Problem 1. Strings in C#
*	Describe the strings in C#.
*	What is typical for the string data type?
*	Describe the most important methods of the String class.*/

using System;
using System.Text;

class StringsInCSharp
{
    static void Main()
    {
        Console.WriteLine("Describe the string in C#:");
        Console.WriteLine("A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects. There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters.\n");

        Console.WriteLine("What is typical for the string data type:");
        Console.WriteLine("* String objects are immutable: they cannot be changed after they have been created. All of the String methods and C# operators that appear to modify a string actually return the results in a new string object.\n* You can create string object using one of the following methods:\n\t- By assigning a string literal to a String variable\n\t- By using a String class constructor\n\t- By using the string concatenation operator (+)\n\t- By retrieving a property or calling a method that returns a string\n\t- By calling a formatting method to convert a value or object to its string representation\n");

        Console.WriteLine("Describe the most important methods of the String class:");
        Console.WriteLine("* Compare(String, String): Compares two specified String objects and returns an integer that indicates their relative position in the sort order.\n* IndexOf(Char, Int32, Int32): Reports the zero-based index of the first occurrence of the specified character in this instance. The search starts at a specified character position and examines a specified number of character positions.\n* PadLeft(Right)(Int32, Char): Returns a new string that right(left)-aligns the characters in this instance by padding them on the left with a specified Unicode character, for a specified total length.\n* Split(Char[]): Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array.\n*Substring(Int32): Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.\n* ToCharArray(): Copies the characters in this instance to a Unicode character array.\n* ToLower()\\ ToUpper(): returns a copy of this string converted to lowercase\\ uppercase.\n");
    }
}