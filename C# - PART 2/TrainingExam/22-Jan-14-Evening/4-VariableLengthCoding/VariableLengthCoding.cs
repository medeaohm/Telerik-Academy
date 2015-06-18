using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VariableLengthCoding
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var num = new byte[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
		{
            num[i] = byte.Parse(numbers[i]);
		}

        var inp = new StringBuilder();
        foreach (var numb in num)
        {
            inp.Append(Convert.ToString(numb, 2).PadLeft(8, '0'));
        }

        string encoddedText = inp.ToString();
        string[] encText = encoddedText.Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries);

        int sizeTable = int.Parse(Console.ReadLine());

        char[] symbolPerCodeLength = new char[sizeTable + 1];
        for (int i = 0; i < sizeTable; i++)
        {
            string currentCodePair = Console.ReadLine();
            char symbol = currentCodePair[0];
            int codeLength = int.Parse(currentCodePair.Substring(1));

            symbolPerCodeLength[codeLength] = symbol;
        }

        for (int i = 0; i < encText.Length; i++)
        {
            var codedSymbol = encText[i];
            Console.Write(symbolPerCodeLength[codedSymbol.Length]);
        }

        Console.WriteLine();
 
    }
}

