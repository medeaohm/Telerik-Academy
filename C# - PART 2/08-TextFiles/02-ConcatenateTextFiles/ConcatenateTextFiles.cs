//### Problem 2. Concatenate text files
//*	Write a program that concatenates two text files into another 
//text file.

using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main()
    {
        Console.WriteLine("Reading the files \"numbers.txt\" and \"letters.txt\"...");
        StreamReader file1 = new StreamReader(@"..\..\numbers.txt");
        StreamReader file2 = new StreamReader(@"..\..\letters.txt");

        StringBuilder concatenated = new StringBuilder();

        concatenated.Append(file1.ReadToEnd());
        concatenated.Append(file2.ReadToEnd());

        file1.Close();
        file2.Close();

        StreamWriter concFile = new StreamWriter(@"..\..\concFile.txt");
        concFile.Write(concatenated);
        concFile.Close();
        Console.WriteLine("Created new file: \"concFile.txt\"");
    }
}
