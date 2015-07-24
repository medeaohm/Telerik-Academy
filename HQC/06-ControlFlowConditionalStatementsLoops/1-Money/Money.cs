using System;

public class Money
{
    public static void Main()
    {
        const int PAPERS_PER_REALM = 400;

        decimal numberOfStudents = decimal.Parse(Console.ReadLine());
        decimal paperSheetsPerStudent = decimal.Parse(Console.ReadLine());
        decimal pricePerRealm = decimal.Parse(Console.ReadLine());

        decimal totalNumberOfPaper = numberOfStudents * paperSheetsPerStudent;
        decimal totalNumberOfRealms = totalNumberOfPaper / PAPERS_PER_REALM;
        decimal totalPrice = totalNumberOfRealms * pricePerRealm;
        Console.WriteLine("{0:F3}", totalPrice);
    }
}
