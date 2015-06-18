//### Problem 1. Odd lines
//*	Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;


class OddLines
{
    static void Main()
    {
        Console.WriteLine("This program reads a text file and prints on the console its odd lines.\n");
        StreamReader text = new StreamReader(@"..\..\numbers.txt");

        using (text)
        {
            int lineNumber = 0;
            string line = text.ReadLine();
            while (line != null)
            {
                line = text.ReadLine();
                lineNumber++;
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);     
                }
            }
        }
    }
}

