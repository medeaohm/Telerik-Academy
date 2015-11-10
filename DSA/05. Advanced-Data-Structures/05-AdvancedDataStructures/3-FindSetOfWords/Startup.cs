// 3. Write a program that finds a set of words(e.g. 1000 words) in a large text(e.g. 100 MB text file).
//  * Print how many times each word occurs in the text.
//  * Hint: you may find a C# trie in Internet.

namespace FindSetOfWords
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Trie;

    public class TrieTest
    {
        private const int WordsCount = 1000000;
        private const int WordsToSearchCount = 1000;

        private static readonly Stopwatch sw = new Stopwatch();
        private static readonly Random rnd = new Random();

        public static void Main()
        {
            var trie = TrieFactory.CreateTrie();
            var wordsToSearch = new List<string>();

            Console.WriteLine("Generating {0} random words....", WordsCount);
            sw.Start();
            for (int i = 0; i < WordsCount; i++)
            {
                var word = GetRandomWord();
                trie.AddWord(word);
                if (((i % 7) == 0) && wordsToSearch.Count < WordsToSearchCount)
                {
                    wordsToSearch.Add(word);
                }
            }

            sw.Stop();
            Console.WriteLine("Generating random words -> Elapsed time: {0}\n", sw.Elapsed);
            sw.Reset();

            SearchWords(wordsToSearch, trie);
        }


        private static string GetRandomWord()
        {
            var newWord = new char[rnd.Next(3, 7)];

            for (int i = 0; i < newWord.Length; i++)
            {
                newWord[i] = ((char)rnd.Next(97, 122));
            }

            return new string(newWord);
        }


        private static void SearchWords(ICollection<string> wordsForSearcing, ITrie trie)
        {
            Console.WriteLine("Searching words... ");
            sw.Start();

            foreach (var word in wordsForSearcing)
            {
                Console.WriteLine("Word: {0} -> apperas {1} times into the text", word, trie.WordCount(word));
            }

            sw.Stop();
            Console.WriteLine("\rSearching words -> Unique words: {0} | Elapsed time: {1}\n", wordsForSearcing.Count, sw.Elapsed);
            sw.Reset();
        }
    }
}
