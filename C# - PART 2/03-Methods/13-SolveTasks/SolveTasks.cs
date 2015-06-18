//### Problem 13. Solve tasks
//*	Write a program that can solve these tasks:
//    *	Reverses the digits of a number
//    *	Calculates the average of a sequence of integers
//    *	Solves a linear equation `a * x + b = 0`
//*	Create appropriate methods.
//*	Provide a simple text-based menu for the user to choose which task to solve.
//*	Validate the input data:
//    *	The decimal number should be non-negative
//    *	The sequence should not be empty
//    *	`a` should not be equal to `0`

using System;
using System.Collections.Generic;
using System.Text;


class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("This program can solve three different tasks!\n");
        Console.WriteLine("Please choose an option from the menu above:");
        Console.WriteLine("|************************ MENU ************************|");
        Console.WriteLine("| 1 - Reverses the digits of a number                  |");
        Console.WriteLine("| 2 - Calculates the average of a sequence of integers |");
        Console.WriteLine("| 3 - Solves a linear equation `a * x + b = 0`         |");
        Console.WriteLine("\\------------------------------------------------------/");

        string choise = Console.ReadLine();
        while (choise != "1" & choise != "2" & choise != "3")
        {
            Console.WriteLine("Invalid input! Please select a valid option");
            choise = Console.ReadLine();
        }
        switch (choise)
        {
            case "1": ReverseDigit();        break;
            case "2": AverageOfSequence();   break;
            case "3": SolveLinearEquation(); break;
            default:                         break;
        }  
    }


    private static void ReverseDigit()
    {
        Console.Write("Please insert a positive integer number... N = ");
        int number = int.Parse(Console.ReadLine());

        while (number < 0)
        {
            Console.WriteLine("Invalid input! The number should be >= 0");
            Console.Write("Please insert a valid number... N = ");
            number = int.Parse(Console.ReadLine());
        }

        string num = number.ToString();
        string[] reversedNumber = new string[num.Length];
        for (int i = 0; i < num.Length; i++)
        {
            reversedNumber[i] = num.Substring(i, 1);
        }
        Array.Reverse(reversedNumber);
        Console.WriteLine("The same number with reversed digits is... {0}", String.Join("",reversedNumber));
    }

    private static void AverageOfSequence()
    {
        Console.Write("Please insert the number of numbers in the sequence... N = ");
        int size = int.Parse(Console.ReadLine());
        
        while (size == 0)
        {
            Console.WriteLine("Sequence should be not empty. \nPlease insert the number of numbers in the sequence... N = ");
            size = int.Parse(Console.ReadLine());
        }

        int[] sequence = new int[size];
        int sum = 0;

        Console.WriteLine("Please insert the numbers of the sequence.");
            
        for (int i = 0; i < size; i++)
        {
            Console.Write("Number {0} = ", i+1);
            sequence[i] = int.Parse(Console.ReadLine());
            sum += sequence[i];
        }
        decimal average = (decimal)sum / (decimal)size;
        Console.WriteLine("Average = {0:0.00}", average);
    }

    private static void SolveLinearEquation()
    {
        Console.WriteLine("I'll solve a equation of the type\n\t ax + b = 0\n");
        Console.Write("Please insert a = ");
        decimal a = decimal.Parse(Console.ReadLine());
        while (a == 0)
        {
            Console.WriteLine("The coefficient a should be != 0");
            Console.Write("Please insert a = ");
            a = decimal.Parse(Console.ReadLine());
        }
        Console.Write("Please insert b = ");
        decimal b = decimal.Parse(Console.ReadLine());

        decimal solution = -b / a;

        Console.WriteLine("\nThe solution is\nx = {0}", solution);
    }
}

