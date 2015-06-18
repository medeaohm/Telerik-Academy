using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TheyAreGreen
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var letters = new char[n];
        for (int i = 0; i < n; i++)
        {
            letters[i] = char.Parse(Console.ReadLine());
        }

        var count = NumberOfWords(letters);
        Console.WriteLine(count);
    }

    private static object NumberOfWords(char[] letters)
    {
        Array.Sort(letters);
        var count = 0;
        do
        {
            if (IsValid(letters))
            {
                count++;
            }
        }
        while (NextPermutation(letters));
        return count;
    }

    private static bool NextPermutation(char[] letters)
    {
        for (int index = letters.Length - 2; index >= 0; index--)
        {
            if (letters[index] < letters[index + 1])
            {
                int swapWithIndex = letters.Length - 1;
                while (letters[index] >= letters[swapWithIndex])
                {
                    swapWithIndex--;
                }

                // Swap i-th and j-th elements
                var tmp = letters[index];
                letters[index] = letters[swapWithIndex];
                letters[swapWithIndex] = tmp;

                Array.Reverse(letters, index + 1, letters.Length - index - 1);
                return true;
            }
        }

        // No more permutations
        return false;
    }

    private static bool IsValid(char[] letters)
    {
        for (int i = 1; i < letters.Length; i++)
        {
            if (letters[i] == letters[i-1])
            {
                return false;
            }
        }
        return true;
    }
}

