//### Problem 8. Replace whole word
//*	Modify the solution of the previous problem to replace only 

//**whole words** (not strings).

using System;
    using System.IO;
    using System.Text;
    class ReplaceWholeWords
    {
        const string FROM = "start";
        const string TO = "finish";
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\input.txt");
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");

            try
            {
                using (reader)
                {
                    StringBuilder currentLine;
                    StringBuilder newCurrentLine;
                    StringBuilder input = new StringBuilder();
                    StringBuilder output = new StringBuilder();

                    using (writer)
                    {
                        while (!reader.EndOfStream)
                        {
                            currentLine = new StringBuilder(reader.ReadLine());
                            input.AppendLine(currentLine.ToString());
                            newCurrentLine = new StringBuilder(Replace(currentLine));
                            writer.WriteLine(newCurrentLine);
                            output.AppendLine(newCurrentLine.ToString());
                        }
                        Console.WriteLine("Original text: \n{0}", input);
                        Console.WriteLine("Text after replacing \"start\" with \"finish\": \n{0}", output);
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

        private static string Replace(StringBuilder currentLine)
        {
            int startIndex = 0;
            string checkLine = currentLine.ToString();
            while (startIndex < currentLine.Length && 
                checkLine.IndexOf(FROM, StringComparison.OrdinalIgnoreCase) != -1)
            {
                startIndex = checkLine.IndexOf(FROM, StringComparison.OrdinalIgnoreCase);
                bool startOfWord = (startIndex == 0 ||
                    !Char.IsLetterOrDigit(currentLine[startIndex - 1]));

                bool endOfWord = ((startIndex + FROM.Length) == currentLine.Length ||
                    !Char.IsLetterOrDigit(currentLine[startIndex + FROM.Length]));

                if (startOfWord && endOfWord)
                {
                    currentLine = currentLine
                        .Replace(currentLine.ToString()
                        .Substring(startIndex, FROM.Length),
                        TO, startIndex, FROM.Length);
                }

                startIndex += TO.Length-1;
                checkLine = currentLine.ToString().Substring(startIndex);
                checkLine = checkLine.PadLeft(currentLine.Length, '*');
            }

            return currentLine.ToString();
        }
}

