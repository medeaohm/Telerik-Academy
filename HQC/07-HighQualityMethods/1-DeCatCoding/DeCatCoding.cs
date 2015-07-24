using System;
using System.Collections.Generic;
using System.Text;

public class DeCatCoding
{
    public const int BASE_CAT_NUMERAL_SYSTEM = 26;
    public const int BASE_HUMAN_NUMERAL_SYSTEM = 21;
    public const int CHAR_CODE_LOWER_A = 97;

    public static void Main()
    {
        string input = Console.ReadLine();
        string[] wordsInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var inputCharsAsNumbers = new List<int>();
        var output = new StringBuilder();

        for (int i = 0; i < wordsInput.Length; i++)
        {
            foreach (char ch in wordsInput[i])
            {
                inputCharsAsNumbers.Add((int)ch - CHAR_CODE_LOWER_A);
            }

            ulong catNumber = CalculateCatNumber(inputCharsAsNumbers);
            string decifredMessage = ReverseString(GetReversedHumanWord(catNumber));

            output.Append(decifredMessage);
            output.Append(" ");
            inputCharsAsNumbers.Clear();
        }

        Console.WriteLine(output.ToString().Trim());
    }

    private static string GetReversedHumanWord(ulong catN)
    {
        var reversedHumanMessage = new StringBuilder();
        while (catN > 0)
        {
            ulong letNum = catN % BASE_CAT_NUMERAL_SYSTEM;
            reversedHumanMessage.Append((char)(letNum + CHAR_CODE_LOWER_A));
            catN /= BASE_CAT_NUMERAL_SYSTEM;
        }

        return reversedHumanMessage.ToString();
    }

    private static string ReverseString(string reversedHumanMessage)
    {
        var decifredMessage = new StringBuilder();
        for (int i = reversedHumanMessage.Length - 1; i >= 0; i--)
        {
            decifredMessage.Append(reversedHumanMessage[i]);
        }

        return decifredMessage.ToString();
    }

    private static ulong CalculateCatNumber(List<int> charsAsNumbers)
    {       
        charsAsNumbers.Reverse();
        ulong catNumber = (ulong)charsAsNumbers[0];
        ulong exp = 1; 

        for (int i = 1; i < charsAsNumbers.Count; i++)
        {
            exp *= BASE_HUMAN_NUMERAL_SYSTEM;
            catNumber += exp * (ulong)charsAsNumbers[i];
        }

        return catNumber;
    }
}