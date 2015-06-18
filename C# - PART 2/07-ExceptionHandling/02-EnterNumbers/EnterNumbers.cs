/*### Problem 2. Enter numbers
*	Write a method `ReadNumber(int start, int end)` that enters an integer number in a given range [`start...end`].
	*	If an invalid number or non-number text is entered, the method should throw an exception.
*	Using this method write a program that enters `10` numbers:	`a1, a2, ... a10`, such that `1 < a1 < ...< a10 < 100`*/

using System;

class EnterNumbers
{
    static void Main()
    {
        int start = 0;
        int end = 99;
        int count = 10;
        int[] all = new int[count];

        try
        {
            for (int i = 0; i < count; i++)
            {
                start = ReadNumber(start, end);
                all[i] = start;  
            }
            Console.WriteLine("{0}", String.Join(", ", all));
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (ArgumentOutOfRangeException ae)
        {
            Console.WriteLine(ae.Message);
        }
        finally
        {
            Console.WriteLine("Bye");
        }
    }

    static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Please insert a number in a range [{0} ... {1}]", start + 1, end + 1);
        int number = int.Parse(Console.ReadLine());
        if (number <= start || number >= end)
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }
}
