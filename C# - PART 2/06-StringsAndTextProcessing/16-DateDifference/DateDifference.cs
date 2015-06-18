//### Problem 16. Date difference
//*	Write a program that reads two dates in the format: `day.month.year` and calculates the number of days between them.

//_Example:_

//    Enter the first date: 27.02.2006
//    Enter the second date: 3.03.2006
//    Distance: 4 days


using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        string[] formats = { "dd.MM.yyyy", "d.MM.yyyy", "dd.M.yyyy", "d.M.yyyy" };

        Console.Write("Enter the first date: ");
        //string startDate = "27.02.2006";
        string startDate = Console.ReadLine();
        DateTime start;
        while (false == DateTime.TryParseExact(startDate, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out start))
        {
            Console.WriteLine("Invalid date entered! Please enter the date in format 'day.month.year'");
            startDate = Console.ReadLine();
        }

        Console.Write("Enter the second date: ");
        string endDate = Console.ReadLine();
        //string endDate = "3.03.2006";
        DateTime end;
        while (false == DateTime.TryParseExact(endDate, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out end))
        {
            Console.WriteLine("Invalid date entered! Please enter the date in format 'day.month.year'");
            endDate = Console.ReadLine();
        }

        int diff = (end - start).Days;
        Console.WriteLine("\nFirst date = {0}", startDate);
        Console.WriteLine("Second date = {0}", endDate);
        Console.WriteLine("The difference is {0} days\n", diff);
    }
}

