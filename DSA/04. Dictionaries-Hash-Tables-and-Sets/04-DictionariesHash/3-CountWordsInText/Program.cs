//3. Write a program that counts how many times each word from given text file `words.txt` appears in it.The character casing differences should be ignored.The result words should be ordered by their number of occurrences in the text.Example:

//    `This is the TEXT. Text, text, text – THIS TEXT! Is this the text?`
//	>is -> 2
//	>the -> 2   
//	>this -> 3  
//	>text -> 6

namespace CountWordsInText
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string textFromFile = File.ReadAllText("../../../TextFiles/words.txt");

            var splittedText = 
                        textFromFile
                        .ToLower()
                        .Split(' ', '.', ',', '–', '!', '?', '/', '|', '(', ')', ':', ';', '[', ']', '{', '}', '\\', '/');

            Dictionary<string, int> occurances = CountOccurances(splittedText);
            var sortedOccurances = occurances.OrderBy(v => v.Value);

            foreach (var pair in sortedOccurances)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }

        }

        private static Dictionary<string, int> CountOccurances(string[] array)
        {
            var occurances = new Dictionary<string, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!occurances.ContainsKey(array[i]))
                {
                    if (array[i] != "")
                    {
                        occurances.Add(array[i], 1);
                    }                
                }
                else
                {
                    occurances[array[i]]++;
                }
            }

            return occurances;
        }
    }
}
