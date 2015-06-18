//### Problem 6. Save sorted names
//*	Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

//_Example:_

//|  input.txt | output.txt |
//|:----------:|:----------:|
//| Ivan       | George     |
//| Peter      | Ivan       |
//| Maria      | Maria      |
//| George     | Peter      |

using System;
using System.Text;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        StreamReader input = new StreamReader(@"..\..\input.txt");
        Console.WriteLine("Reading the text file \"input.txt\"... \n");
        StringBuilder names = new StringBuilder();
        using (input)
        {
            string line = input.ReadLine();
            while (line != null)
            {
                names.Append(line + ' ');
                line = input.ReadLine();
            }
            Console.WriteLine("Before sorting: {0}", names);

            StreamWriter output = new StreamWriter(@"..\..\output.txt");
            string[] namesToArray = (names.ToString()).Split(' ');
            Array.Sort(namesToArray);
            for (int i = 1; i < namesToArray.Length; i++)
            {
                output.WriteLine(namesToArray[i]);
            }
            output.Close();
            Console.WriteLine("After sorting: {0}\n", String.Join(" ",namesToArray));
            Console.WriteLine("The output is saved in the text file \"output.txt\"... \n");
        }
    }
}

