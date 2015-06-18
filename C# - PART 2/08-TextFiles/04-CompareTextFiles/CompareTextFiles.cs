//### Problem 4. Compare text files
//*	Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//*	Assume the files have equal number of lines.


using System;
using System.Text;
using System.IO;


class CompareTextFiles
{
    static void Main()
    {
        Console.WriteLine("This program compare 2 text files line by line...\n");
        StreamReader file1 = new StreamReader(@"..\..\file1.txt");
        StreamReader file2 = new StreamReader(@"..\..\file2.txt");

        string line1 = file1.ReadLine();
        string line2 = file2.ReadLine();

        int lineNumber = 0;
        while (line1 != null & line2 != null)
        {
            if (line1 == line2)
            {
                Console.WriteLine("Lines {0} are equal: {1}", lineNumber, line1);     
            }
            lineNumber++;
            line1 = file1.ReadLine();
            line2 = file2.ReadLine();
        }
        file1.Close();
        file2.Close();
    }
}

