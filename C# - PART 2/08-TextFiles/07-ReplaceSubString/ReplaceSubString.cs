//### Problem 7. Replace sub-string
//*	Write a program that replaces all occurrences of the sub-

//string `start` with the sub-string `finish` in a text file.
//*	Ensure it will work with large files (e.g. `100 MB`).

using System;
using System.Text;
using System.IO;

class ReplaceSubString
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        StringBuilder replace = new StringBuilder(); //using StringBuilder, the app will work with large files
        using (reader)
        {
            Console.WriteLine("Reading the text file \"input.txt\": \n");
            replace.Append(reader.ReadToEnd());
            Console.WriteLine("Before replacing: \n{0}", replace);
            replace.Replace("start", "finish");
        }

        StreamWriter writer = new StreamWriter(@"..\..\output.txt");
        using (writer)
        {
            Console.WriteLine("\n\nAfter replacing: \n{0}", replace);
            writer.Write(replace);
            Console.WriteLine("\n\nThe output is saved in the text file \"output.txt\" in the following path: \n{0} \n", Path.GetFullPath(@"..\..\"));
        }
    }
}

