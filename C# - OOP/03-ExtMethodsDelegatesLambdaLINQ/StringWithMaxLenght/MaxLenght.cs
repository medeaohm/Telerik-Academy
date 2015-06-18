namespace StringWithMaxLenght
{
    using System;
    using System.Linq;

    public class MaxLenght
    {
        
        //### Problem 17. 
        //*	Write a program to return the string with maximum length from an array of strings.
        //*	Use LINQ.

        public static void Main()
        {
            string[] listOfStrings =
            {
                "Asus",
                "Maria",
                "Neprotivokonstitucionstvuvatelstvuvayte",
                "aaaaaa",
                "hello"
            };
            Console.WriteLine("List of strings: ");
            foreach (string s in listOfStrings)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("\n");
            var maxStringL = listOfStrings.OrderByDescending(s => s.Length).FirstOrDefault();
            Console.WriteLine("The string with maximum lenght is: {0}", maxStringL);
        }
    }
}
