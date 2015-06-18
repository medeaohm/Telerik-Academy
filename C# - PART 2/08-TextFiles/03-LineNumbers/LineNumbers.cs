//### Problem 3. Line numbers
//*	Write a program that reads a text file and inserts line numbers in front of each of its lines.
//*	The result should be written to another text file.

using System;
using System.Text;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        Console.WriteLine("Reading the file \"letters.txt\"...\n");
        StreamReader text = new StreamReader(@"..\..\letters.txt");

        StringBuilder lineAndText = new StringBuilder();

        using (text)
        {
            int lineNumber = 0;
            string line = text.ReadLine();
            string lineNumb = null;
            while (line != null)
            {
                lineNumb = lineNumber.ToString();
                lineAndText.AppendLine(lineNumb + '-' + line);
                line = text.ReadLine();
                lineNumber++;
            }
            StreamWriter concFile = new StreamWriter(@"..\..\LineAndText.txt");
            concFile.Write(lineAndText);
            concFile.Close();
            Console.WriteLine("Created new file: \"LineAndText.txt\"\n");
        }
    }
}
