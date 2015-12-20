namespace Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Numerics;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine().Replace(',', ' ').Trim().ToLower();
            string text = Console.ReadLine().Replace(',', ' ').Trim().ToLower();
            //string word = "a";
            //string text = new StringBuilder().Insert(0, "ab", 500000).ToString();

            BigInteger combinations = 0;
            foreach (var match in Regex.Matches(text, word))
            {
                combinations++;
            }

            for (int i = 1; i < word.Length; i++)
            {
                var pre = word.Substring(0, word.Length - i);
                var suf = word.Substring((word.Length - i), word.Length - (word.Length - i));
                BigInteger countPre = 0;
                BigInteger countSuf = 0;
                foreach (var match in Regex.Matches(text, pre))
                {
                    countPre++;
                }
                foreach (var match in Regex.Matches(text, suf))
                {
                    countSuf++;
                }

                combinations += (countPre * countSuf);
            }


            Console.WriteLine(combinations);
        }
    }
}