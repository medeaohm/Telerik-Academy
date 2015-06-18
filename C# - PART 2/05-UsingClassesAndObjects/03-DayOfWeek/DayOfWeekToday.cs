//### Problem 3. Day of week
//*	Write a program that prints to the console which day of the week is today.
//*	Use `System.DateTime`.

using System;

class DayOfWeekToday
{
    static void Main()
    {
        DayOfWeek today = DateTime.Today.DayOfWeek;
        Console.WriteLine("Today is {0}\n", today);
    }
}

