//### Problem 9. Delete odd lines
//*	Write a program that deletes from given text file all odd lines.
//*	The result should be in  the same file.

using System;
using System.Text;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        Console.WriteLine("This program reads a text file and delete its odd lines.\n");
        StreamReader text = new StreamReader(@"..\..\file.txt");
        StringBuilder output = new StringBuilder();

        using (text)
        {
            Console.WriteLine("In the original file:");
            int lineNumber = 0;
            string line = text.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = text.ReadLine();
                lineNumber++;
                if (lineNumber % 2 != 0)
                {
                    output.AppendLine(line);
                }
            }
        }

        StreamWriter writer = new StreamWriter(@"..\..\file.txt");
        using (writer)
        {
            Console.WriteLine("\nAfter deleting odd lines: \n{0}", output);
            writer.Write(output);   
        }
    }
}

