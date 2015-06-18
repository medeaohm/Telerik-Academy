//### Problem 13. Count words
//*	Write a program that reads a list of words from the file `words.txt` and finds how many times each of the words is contained in another file `test.txt`.
//*	The result should be written in the file `result.txt` and the words should be sorted by the number of their occurrences in descending order.
//*	Handle all possible exceptions in your methods.

using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class CountWords
{
    static void Main()
    {
        StreamReader readerWords = new StreamReader(@"..\..\words.txt");
        StreamReader readerTest = new StreamReader(@"..\..\test.txt");
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");

        try
        {
            using (readerWords)
            {
                StringBuilder words = new StringBuilder();
                string linewords = readerWords.ReadLine();
                while (linewords != null)
	            {
                    words.Append(linewords + " ");
                    linewords = readerWords.ReadLine();
	            }
                string[] w = words.ToString().Split(new char[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
                using (readerTest)
                {
                    using (writer)
                    {
                        string test = readerTest.ReadToEnd();
                        Console.WriteLine("\nOriginal text: \n{0}", test);
                        Console.WriteLine("\nWords to find: {0}\n", words);

                        //Convert the string into an array of words 
                        string[] source = test.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

                        // Create the query.  Use ToLowerInvariant to match "data" and "Data"  
                        foreach (string word in w)
                        {
                            var matchQuery = from someWord in source
                                             where someWord.ToLowerInvariant() == word.ToLowerInvariant()
                                             select someWord;

                            // Count the matches, which executes the query. 
                            int wordCount = matchQuery.Count();
                            Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", wordCount, word);
                            string result = word + " --> " + wordCount;
                            writer.WriteLine(result);
                        }
                        
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
    }
}

