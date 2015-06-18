//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.

using System;
using System.Text;


class EncodeDecode
{
    static void Main()
    {
        Console.WriteLine("Please enter the text to encode: ");
        string input = Console.ReadLine();
        Console.Write("\nPlease enter the key: ");
        string key = Console.ReadLine();

        StringBuilder encripted = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            encripted.Append((char)(input[i] ^ key[i % key.Length]));
        }

        Console.WriteLine("\nThe encripted text is: {0}", encripted);

        StringBuilder decript = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            decript.Append((char)(encripted[i] ^ key[i % key.Length]));
        }

        Console.WriteLine("\nThe decripted text is: {0}", decript);
    }
}
