//2. Write a program that reads N integers from the console and reverses them using a stack.
//  - Use the `Stack<int>` class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a sequence of numbers separated with a space");

        var input = Console.ReadLine();
        var splittedInput = input.Split(' ');

        Stack<int> inputStack = new Stack<int>();

        foreach (var number in splittedInput)
        {
            inputStack.Push(int.Parse(number));
        }
        inputStack.Reverse();

        Console.WriteLine("Reversed sequence:");
        foreach (var num in inputStack)
        {
            Console.Write(num + " ");
        }
    }
}

