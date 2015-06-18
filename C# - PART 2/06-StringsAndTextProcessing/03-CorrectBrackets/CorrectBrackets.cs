/*### Problem 3. Correct brackets
*   Write a program to check if in a given expression the brackets are put correctly.
_Example of correct expression:_ `((a+b)/5-d)`.
_Example of incorrect expression:_ `)(a+b))`.*/
using System;
using System.Text;

class CorrectBrackets
{
    private static readonly char[] open = { '(', '[', '{' };
    private static readonly char[] close = { ')', ']', '}' };

    static void Main()
    {
        Console.WriteLine("Please enter an expression with brackets...");
        string expression = Console.ReadLine();
        bool correct = CorrectBra(expression);

        if (correct)
        {
            Console.WriteLine("The expression is correct");
        }
        else
        {
            Console.WriteLine("The expression is NOT correct");
        }
    }

    private static bool CorrectBra(string expr)
    {
        bool correct = false;
        int countOpen = 0;
        int countClose = 0;

        foreach (char bracket in open)
        {
            foreach (char character in expr)
            {
                if (character == bracket)
                {
                    countOpen++;
                }
            }
        }

        foreach (char bracket in close)
        {
            foreach (char character in expr)
            {
                if (character == bracket)
                {
                    countClose++;
                }
            }
        }
        if (countOpen == countClose)
        {
            correct = true;
        }
        return correct;
    }
}
