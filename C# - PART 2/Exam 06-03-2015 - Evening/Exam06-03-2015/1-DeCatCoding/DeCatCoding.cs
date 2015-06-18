using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DeCatCoding
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] wordsInput = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        var catsNum = new List<int>();
        var cat = new StringBuilder();

        var output = new StringBuilder();
        for (int i = 0; i < wordsInput.Length; i++)
		{
            
			    foreach (char ch in wordsInput[i])
                {
                    catsNum.Add(((int)ch - 97));
                }
                ulong catN = CatNumber(catsNum);
                string humanN = Human(catN);
                output.Append(humanN);
                output.Append(" ");
                catsNum.Clear();
                //Console.WriteLine(catN);
                //Console.WriteLine(humanN);
		}
        Console.WriteLine(output.ToString().Trim());
    }

    private static string Human(ulong catN)
    {
        var human = new StringBuilder();
        while (catN > 0)
        {
            ulong letNum = catN % 26;
            human.Append((char)(letNum + 97));
            catN /= 26;
        }
        var res = new StringBuilder(); 
        for (int i = human.Length - 1; i >=0 ; i--)
        {
            res.Append(human[i]);
        }
        return res.ToString();
    }

    private static ulong CatNumber(List<int> catsNum)
    {
        
        catsNum.Reverse();
        ulong cat = (ulong)catsNum[0];
        ulong exp = 1; 
        for (int i = 1; i < catsNum.Count; i++)
        {
            exp *= 21;
            cat += exp * (ulong)catsNum[i];
        }
        return cat;
    }
}

