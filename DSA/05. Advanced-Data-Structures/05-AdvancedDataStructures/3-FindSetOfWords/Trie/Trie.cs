using System;
using System.Collections.Generic;
using System.Text;

namespace Trie
{
    internal class Trie : ITrie
    {
        private TrieNode rootTrieNode
        {
            get; set;
        }

        internal Trie(TrieNode rootTrieNode)
        {
            this.rootTrieNode = rootTrieNode;
        }

        public void AddWord(string word)
        {
            AddWord(rootTrieNode, word.ToCharArray());
        }

        public void RemoveWord(string word)
        {
            var trieNode = GetTrieNode(word);
            if (trieNode == null || !trieNode.IsWord)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("{0} does not exist in trie.", word)
                    );
            }
            trieNode.RemoveNode(rootTrieNode);
        }

        public ICollection<string> GetWords()
        {
            var words = new List<string>();
            var buffer = new StringBuilder();
            GetWords(rootTrieNode, words, buffer);
            return words;
        }

        public ICollection<string> GetWords(string prefix)
        {
            ICollection<string> words;
            if (string.IsNullOrEmpty(prefix))
            {
                words = GetWords();
            }
            else
            {
                var trieNode = GetTrieNode(prefix);
                // Empty list if no prefix match
                words = new List<string>();
                if (trieNode != null)
                {
                    var buffer = new StringBuilder();
                    buffer.Append(prefix);
                    GetWords(trieNode, words, buffer);
                }
            }
            return words;
        }

        public bool HasWord(string word)
        {
            var trieNode = GetTrieNode(word);
            return trieNode != null && trieNode.IsWord;
        }

        public int WordCount(string word)
        {
            var trieNode = GetTrieNode(word);
            return (trieNode == null ? 0 : trieNode.WordCount);
        }

        public ICollection<string> GetLongestWords()
        {
            var longestWords = new List<string>();
            var buffer = new StringBuilder();
            var length = 0;
            GetLongestWords(rootTrieNode, longestWords, buffer, ref length);
            return longestWords;
        }

        public void Clear()
        {
            rootTrieNode.Clear();
        }

        private TrieNode GetTrieNode(string prefix)
        {
            var trieNode = rootTrieNode;
            foreach (var prefixChar in prefix)
            {
                trieNode = trieNode.GetChild(prefixChar);
                if (trieNode == null)
                {
                    break;
                }
            }
            return trieNode;
        }

        /// <summary>
        /// Recursive method to add word. Gets the first char of the word, 
        /// creates the child TrieNode if null, and recurses with the first
        /// char removed from the word. If the word length is 0, return.
        /// </summary>
        private void AddWord(TrieNode trieNode, char[] word)
        {
            if (word.Length == 0)
            {
                trieNode.WordCount++;
                return;
            }
            var c = Utilities.FirstChar(word);
            TrieNode child = trieNode.GetChild(c);
            if (child == null)
            {
                child = TrieFactory.CreateTrieNode(c, trieNode);
                trieNode.SetChild(child);
            }
            var cRemoved = Utilities.FirstCharRemoved(word);
            AddWord(child, cRemoved);
        }

        /// <summary>
        /// Recursive method to get all the words starting from given TrieNode.
        /// </summary>
        private void GetWords(TrieNode trieNode, ICollection<string> words, StringBuilder buffer)
        {
            if (trieNode.IsWord)
            {
                words.Add(buffer.ToString());
            }
            foreach (var child in trieNode.GetChildren())
            {
                buffer.Append(child.Character);
                GetWords(child, words, buffer);
                // Remove recent character
                buffer.Length--;
            }
        }

        private void GetLongestWords(TrieNode trieNode, ICollection<string> longestWords, StringBuilder buffer, ref int length)
        {
            if (trieNode.IsWord)
            {
                if (buffer.Length > length)
                {
                    longestWords.Clear();
                    length = buffer.Length;
                }
                if (buffer.Length >= length)
                {
                    longestWords.Add(buffer.ToString());
                }
            }
            foreach (var child in trieNode.GetChildren())
            {
                buffer.Append(child.Character);
                GetLongestWords(child, longestWords, buffer, ref length);
                // Remove recent character
                buffer.Length--;
            }
        }
    }
}