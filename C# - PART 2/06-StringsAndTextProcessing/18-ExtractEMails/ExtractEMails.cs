/*### Problem 18. Extract e-mails
*	Write a program for extracting all email addresses from given text.
*	All sub-strings that match the format `<identifier>@<host>?<domain>` should be recognized as emails.*/

using System;
using System.Text;

class ExtractEMails
{
    static readonly char[] separators = new char[] { ' ', '\t', ',', '!', '?', ':', ';', '(', ')', '{', '}', '[', ']' };

    static void Main()
    {
        Console.WriteLine("Please enter some text and I will extract e-mail addresses (if present): ");
        // string text = Console.ReadLine();
        string text = "Hi! My email @ yahoo is myemail@yahoo.com. I also have 101mailGO@mail_provider.co.uk! You can write me to my work-email too:work_mail@privider.at.my.work";
        Console.WriteLine(text);

        string[] sample = text.Split(separators);
        StringBuilder emails = new StringBuilder();

        foreach (string word in sample)
        {
            char at = '@';
            int index = word.IndexOf(at);

            if (index != -1 & index != 0 & index != word.Length - 1)
            {
                emails.Append(word);
                emails.Append(" ");
            }
        }
        if (emails.Length == 0)
        {
            Console.WriteLine("\nNo e-mail addresses found!");
        }
        else
        {
            string[] mails = (emails.ToString()).Split(' ');
            Console.WriteLine("\nThe e-mail found are: ");
            foreach (string email in mails)
            {
                Console.WriteLine(email);
            }
        }
    }
}