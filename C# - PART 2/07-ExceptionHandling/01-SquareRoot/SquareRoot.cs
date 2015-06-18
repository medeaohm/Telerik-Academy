/*### Problem 1. Square root
*	Write a program that reads an integer number and calculates and prints its square root.
	*	If the number is invalid or negative, print `Invalid number`.
	*	In all cases finally print `Good bye`.
*	Use `try-catch-finally` block..*/

using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("Please insert a positive integer number: ");
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            double sqrt = Math.Sqrt(number);
            Console.WriteLine("The square root of {0} is {1}", number, sqrt);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format number!");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Invalid format number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Cannot estimate the square root of a negative number");
        }
        catch
        {
            Console.WriteLine("Indefined error");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
