//### Problem 25. Extract text from HTML
//*	Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

//_Example input:_

/*    <html>
      <head><title>News</title></head> <body><p><a href="http://academy.telerik.com">Telerik Academy</a>aims to provide free real-world    practical training for young people who want to turn into skilful .NET software engineers.</p></body>
    </html>
*/
//_Output:_ 

//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.

using System;
using System.Text;

class ExtractTextFromHTML
{
    static void Main()
    {
        //Console.WriteLine("Enter text: ");
        //string input = Console.ReadLine();
        string input = "<html> <head><title>News</title></head> <body><p><a href=\"http:///academy.telerik.com\"> Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body> </html>";
        Console.WriteLine("Before parsing: \n{0}", input);
        
        int startTitle = input.IndexOf("<head><title>");
        int endTitle = input.IndexOf("</title></head>");
        string title = input.Substring(startTitle + 13, endTitle - startTitle - 13);
        Console.WriteLine("\nTitle: {0}", title);

        int startBody = input.IndexOf("<body><p>");
        int endBody = input.IndexOf("</p></body>");
        string body = input.Substring(startBody + 9, endBody - startBody - 9);

        int indexStartRemove = body.IndexOf("<a href=\"");
        int indexEndRemove = body.IndexOf("\">");
        int rem = indexEndRemove + 2 - indexStartRemove;
        body = body.Remove(indexStartRemove, rem);
        body = body.Replace("</a>", " ");

        Console.WriteLine("\nBody: {0}", body);
    }
}

