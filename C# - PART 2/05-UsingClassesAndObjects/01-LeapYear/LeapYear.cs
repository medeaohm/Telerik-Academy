//### Problem 1. Leap year
//*	Write a program that reads a year from the console and checks whether it is a leap one.
//*	Use `System.DateTime`.

using System;


class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Please enter a year...");
        Console.Write("Year = ");
        int year = int.Parse(Console.ReadLine());
        bool leapYear = DateTime.IsLeapYear(year);

        if (leapYear)
        {
            Console.WriteLine("{0} is leap year", year);
        }
        else
        {
            Console.WriteLine("{0} is not leap year", year);
        }
    }
}
