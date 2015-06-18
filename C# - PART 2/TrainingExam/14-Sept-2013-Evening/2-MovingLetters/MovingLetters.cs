using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MovingLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        //string input = "Fun exam right";
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
     

        var output = new StringBuilder();
        var longestWord = 0;
        foreach (string word in words)
        {
            longestWord = Math.Max(longestWord, word.Length);
        }

        var rev = new List<string>(); ;
        for (int i = 0; i < words.Length; i++)
        {
            char[] r = words[i].ToCharArray();
            Array.Reverse(r);

            rev.Add(new string(r));
        }

        for (int i = 0; i < longestWord; i++)
        {
            foreach (var word in rev)
            {
                if (word.Length > i)
                {
                    output.Append(word[i]);
                }
            }
        }
       // Console.WriteLine(output.ToString());

        for (int i = 0; i < output.Length; i++)
        {
            char letter = output[i];
            int positions = char.ToLower(letter) - 'a' + 1;
            MoveRight(output, i, positions);
        }
        Console.WriteLine(output.ToString());
    }

    private static void MoveRight(StringBuilder output, int i, int positions)
    {
        char letter = output[i];
        output.Remove(i, 1);
        int newPos = (i + positions) % (output.Length + 1);
        output.Insert(newPos, letter);
    }
}

