//### Problem 10. Extract text from XML
//*	Write a program that extracts from given XML file all the text without the tags.

//_Example:_

//`<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>`


using System;
using System.Text;
using System.IO;

class ExtractTextFromXML
    {
        const char SPACE = ' ';

        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\input.txt");
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");

            try
            {
                using (reader)
                {
                    string xml = reader.ReadToEnd();
                    Console.WriteLine("Original text: \n{0}", xml);

                    using (writer)
                    {
                        StringBuilder result = new StringBuilder();
                        result.Append(RemoveXMLTags(xml));
                        writer.Write(result);
                        Console.WriteLine("\nText after removing tags: \n{0}", result);
                        Console.WriteLine("\n\nThe output is saved in the text file \"output.txt\" in the following path: \n{0} \n", Path.GetFullPath(@"..\..\"));
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

        private static string RemoveXMLTags(string xml)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder current = new StringBuilder();
            bool insideTag = false;

            foreach (var letter in xml)
            {
                if (insideTag)
                {
                    if (letter == '>')
                    {
                        insideTag = false;
                    }
                    continue;
                }
                else
                {
                    if (letter == '<')
                    {
                        if (current.Length > 0)
                        {
                            result.AppendLine(current.ToString());
                            current.Clear();
                        }
                        insideTag = true;
                    }
                    else
                    {
                        current.Append(letter);
                    }
                    continue;
                }
            }
            return result.ToString();
        }
    }

