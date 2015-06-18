/*### Problem 19. Dates from text in Canada
*	Write a program that extracts from a given text all dates that match the format `DD.MM.YYYY`.
*	Display them in the standard date format for Canada.*/

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class DatesFromTextInCanada
{
    static readonly char[] separators = new char[] { ' ', '\t', ',', '!', '?', ';', '(', ')', '{', '}', '[', ']', '\n' };

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

        string text = "02.10.2015 ciao 03.5.2015 bkgjg dog 2.1.2015 cat,mouse! 2/12/2013 2.10.2015";
        Console.WriteLine("Original text: {0}", text);

        string format = "d.M.yyyy";
        CultureInfo provider = Thread.CurrentThread.CurrentCulture;

        string[] splitted = text.Split(separators);

        foreach (string word in splitted)
        {
            try
            {
                DateTime date = DateTime.ParseExact(word, format, provider);
                Console.WriteLine("{0}", word);
            }
            catch (FormatException)
            {
                continue;
            }
        }
    }
}
