//### Problem 4. Download file
//*	Write a program that downloads a file from Internet (e.g. [Ninja image](http://telerikacademy.com/Content/Images/news-img01.png)) and stores it the current directory.
//*	Find in Google how to download files in C#.
//*	Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;
using System.IO;

class DownloadFile
{
    static void Main()
    {
        Console.WriteLine("Downloading file...");
        try
        {
            WebClient webCl = new WebClient();
            webCl.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", @"TelerikNinja.jpg");
            Console.WriteLine("\nDone!");
            Console.WriteLine("The picture is saved at {0}.\n", Directory.GetCurrentDirectory());
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WebException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch
        {
            Console.WriteLine("Something bad happend...");
        }
        finally
        {
            Console.WriteLine("Bye bye!");
        }
    }
}

    //class DownloadFile
    //{
    //    const string URL = "http://telerikacademy.com/Content/Images/news-img01.png";
    //    const string FILE_NAME = "TelerikNinja.png";
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            WebClient webCilend = new WebClient();
    //            webCilend.DownloadFile(URL, FILE_NAME);
    //            Console.WriteLine("The picture is saved at {0}.", Directory.GetCurrentDirectory());
    //        }
    //        catch (UnauthorizedAccessException exception)
    //        {
    //            Console.WriteLine(exception.Message);
    //        }
    //        catch (NotSupportedException exception)
    //        {
    //            Console.WriteLine(exception.Message);
    //        }
    //        catch (WebException exception)
    //        {
    //            Console.WriteLine(exception.Message);
    //        }
    //        catch (ArgumentException exception)
    //        {
    //            Console.WriteLine(exception.Message);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Good bye.");
    //        }
    //    }
    //}