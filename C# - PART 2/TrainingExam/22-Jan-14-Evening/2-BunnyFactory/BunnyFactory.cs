using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class BunnyFactory
{
    static List<int> bunnyCages;
    static string result;

    static void Main()
    {
        result = string.Empty;
        bunnyCages = new List<int>();
        string input = Console.ReadLine();;
        while (input != "END")
        {
            bunnyCages.Add(int.Parse(input));
            input = Console.ReadLine();
        }

        Calculate();
        PrintResult();
    }

    private static void Calculate()
    {
        int counter = 1;
        while (true)
        {
            if (!NextConversion(counter))
            {
                break;
            }

            counter++;
        }
    }

    private static bool NextConversion(int counter)
    {
        if (counter >= bunnyCages.Count)
        {
            return false;
        }

        int firstCage = 0;

        for (int i = 0; i < counter; i++)
        {
            firstCage += bunnyCages[i];
        }

        if (firstCage >= bunnyCages.Count)
        {
            return false;
        }

        List<int> bunniesToTransfer = new List<int>();

        for (int i = counter; i < counter + firstCage; i++)
        {
            bunniesToTransfer.Add(bunnyCages[i]);
        }

        string sum = CalculateSumOfNumbers(bunniesToTransfer);
        string product = CalculateProductOfNumbers(bunniesToTransfer);

        List<int> nextCages = new List<int>();
        foreach (var symbol in sum)
        {
            AddSymbol(nextCages, symbol);
        }

        foreach (var symbol in product)
        {
            AddSymbol(nextCages, symbol);
        }

        for (int i = counter + firstCage; i < bunnyCages.Count; i++)
        {
            foreach (var symbol in bunnyCages[i].ToString())
            {
                AddSymbol(nextCages, symbol);
            }
        }

        bunnyCages = nextCages;
        return true;
    }

    private static void AddSymbol(List<int> symbols, char symbol)
    {
        if (symbol != '0' && symbol != '1')
        {
            symbols.Add(symbol - '0');
        }
    }

    private static string CalculateProductOfNumbers(List<int> listOfNumbers)
    {
        BigInteger product = 1;

        foreach (var number in listOfNumbers)
        {
            product *= number;
        }
        return product.ToString();
    }

    private static string CalculateSumOfNumbers(List<int> listOfNumbers)
    {
        BigInteger sum = 0;

        foreach (var number in listOfNumbers)
        {
            sum += number;
        }

        return sum.ToString();
    }

    static void PrintResult()
    {
        result = string.Join(" ", bunnyCages);
        Console.WriteLine(result);
    }
}

