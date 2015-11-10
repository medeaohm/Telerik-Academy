namespace Trie
{
    using System.Collections.Generic;

    public interface ITrie
    {
        void AddWord(string word);

        void RemoveWord(string word);

        ICollection<string> GetWords();

        ICollection<string> GetWords(string prefix);

        bool HasWord(string word);

        int WordCount(string word);

        ICollection<string> GetLongestWords();

        void Clear();
    }
}
