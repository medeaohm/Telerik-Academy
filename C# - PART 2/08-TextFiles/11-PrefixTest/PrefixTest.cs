//### Problem 11. Prefix "test"
//*	Write a program that deletes from a text file all words that start with the prefix `test`.
//*	Words contain only the symbols `0…9`, `a…z`, `A…Z`, `_`.

using System;
using System.Text;
using System.IO;
using System.Linq;


class PrefixTest
{
    const string PREFIX = "text";

    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        StreamWriter writer = new StreamWriter(@"..\..\output.txt");
        StringBuilder result = new StringBuilder(); 

        using (reader)
        {
            Console.WriteLine("Reading the text file \"input.txt\": \n");
            StringBuilder currentLine;
            using (writer)
            {
                while (!reader.EndOfStream)
                {
                    currentLine = new StringBuilder(reader.ReadLine());
                    string[] separatedWords = currentLine.ToString().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                           .Where(x => !x.StartsWith("test", StringComparison.OrdinalIgnoreCase))
                           .ToArray();

                    result.AppendLine(String.Join(" ", separatedWords));
                    writer.Write(result.ToString());
                    Console.WriteLine("The output is saved in the text file \"output.txt\"... \n");
                }
            }
        }
    }
}



////Write a program that deletes from a text file all words that start with the prefix test.
////Words contain only the symbols 0…9, a…z, A…Z, _.
//namespace PrefixTest
//{
//    using System;
//    using System.IO;
//    using System.Text;
//    using System.Linq;
//    class PrefixTest
//    {
//        static void Main(string[] args)
//        {
//            string inputPath = @"..\..\..\txt\11.input.txt";
//            string outputPath = @"..\..\..\txt\11.output.txt";
//            StringBuilder result = new StringBuilder();

//            try
//            {
//                using (StreamReader reader = new StreamReader(inputPath))
//                {
//                    string currentLine;
//                    while (!reader.EndOfStream)
//                    {
//                        currentLine = reader.ReadLine();
//                        string[] separatedWords = currentLine
//                            .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
//                            .Where(x => !x.StartsWith("test", StringComparison.OrdinalIgnoreCase))
//                            .ToArray();

//                        result.AppendLine(String.Join(" ", separatedWords));
//                    }
//                }


//                using (StreamWriter writer = new StreamWriter(outputPath))
//                {
//                    writer.Write(result.ToString());

//                    Console.WriteLine("DIRECTORY: " +
//                       Path.GetFullPath(outputPath).Replace(Path.GetFileName(outputPath), String.Empty));

//                    Console.WriteLine("A file {0} has been created with the removed test- words.",
//                        Path.GetFileName(outputPath));
//                }
//            }
//            catch (DirectoryNotFoundException exception)
//            {
//                Console.WriteLine(exception.Message);
//            }
//            catch (FileNotFoundException exception)
//            {
//                Console.WriteLine(exception.Message);
//            }
//            catch (FileLoadException exception)
//            {
//                Console.WriteLine(exception.Message);
//            }
//            catch (EndOfStreamException exception)
//            {
//                Console.WriteLine(exception.Message);
//            }
//            catch (IOException exception)
//            {
//                Console.WriteLine(exception.Message);
//            }
//        }
//    }
//}

