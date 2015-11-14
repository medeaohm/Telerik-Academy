namespace Strings.ConsoleClient
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string searchTerm = "if";
            string text = "Hello! Let's check if this works...";

            // the service must running to do this.

            StringsServiceClient client = new StringsServiceClient();
            int result = client.CountHowManyTimesIsContained(text, searchTerm);
            Console.WriteLine("The text: {0} \nContains word {1} - {2} times", text, searchTerm, result);
        }
    }
}
