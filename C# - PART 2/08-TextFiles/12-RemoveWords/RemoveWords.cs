//### Problem 12. Remove words
//*	Write a program that removes from a text file all words listed in given another text file.
//*	Handle all possible exceptions in your methods.

using System;
using System.Linq;
using System.Text;
using System.IO;

class RemoveWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        StreamWriter writer = new StreamWriter(@"..\..\output.txt");
        StreamReader words = new StreamReader(@"..\..\words.txt");

        try
        {
            using (reader)
            {
                StringBuilder input = new StringBuilder();
                input.Append(reader.ReadToEnd());
                Console.WriteLine("Before deleting: \n{0}", input);
                using (words)
                {
                    string[] wordsToDelete = words.ReadToEnd().Split(' ');
                    Console.WriteLine("\nWords to delete: {0}", String.Join(", ", wordsToDelete));
                    using (writer)
                    {
                        StringBuilder output = input;
                        string result = output.ToString();

                        foreach (string word in wordsToDelete)
                        {                   
                            result = result.Replace(word,String.Empty);
                        }
                        writer.Write(result);
                        Console.WriteLine("\nAfter delete: \n{0}\n", result);
                        Console.WriteLine("\n\nThe output is saved in the text file \"output.txt\" in the following path: \n{0} \n", Path.GetFullPath(@"..\..\"));
                    }
                }
            }
        }
        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileLoadException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (EndOfStreamException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (IOException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentNullException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch 
        {
            Console.WriteLine("Something bad happend...");
        }
    }
}

