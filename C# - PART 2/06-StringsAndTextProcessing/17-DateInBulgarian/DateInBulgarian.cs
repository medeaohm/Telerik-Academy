/*### Problem 17. Date in Bulgarian
*	Write a program that reads a date and time given in the format: `day.month.year hour:minute:second` and prints the date and time after `6` hours and `30` minutes (in the same format) along with the day of week in Bulgarian.*/

using System;
using System.Globalization;
using System.Threading;
using System.Text;

class DateInBulgarian
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        string format = "d.M.yyyy H:m:s";
        CultureInfo provider = CultureInfo.GetCultureInfo("bg-BG");

        Console.WriteLine("Please insert a date in a format 'day.month.year hour:minute:second': ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), format, provider);

        DateTime newDate = date.AddHours(6).AddMinutes(30);

        Console.WriteLine(newDate.ToString("dd.MM.yyyy HH:mm:ss dddd"), provider);
    }
}
