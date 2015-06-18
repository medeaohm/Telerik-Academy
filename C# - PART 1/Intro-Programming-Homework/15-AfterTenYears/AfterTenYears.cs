using System;

//### Problem 15.*	Age after 10 Years
//*	Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.


class AfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter Your Birthday (DD/MM/YYYY)....");
        DateTime BirthDay = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;

        int TodayYear = today.Year;
        int TodayMonth = today.Month;
        int TodayDay = today.Day;
        int BirthYear = BirthDay.Year;
        int BirthMonth = BirthDay.Month;
        int BirthD = BirthDay.Day;
        int CurrentYears = TodayYear - BirthYear;
        int CurrentMonths = TodayMonth - BirthMonth;
        int CurrentDays = TodayDay - BirthD;


        int CurrentAge;

        if (CurrentMonths > BirthMonth)
        {
            CurrentAge = CurrentYears;
        }
        else
        {
            if (CurrentMonths < 0)
            {
                CurrentAge = CurrentYears - 1;
            }
            else

                if (CurrentMonths == 0 & CurrentDays >= 0)
                {
                    CurrentAge = CurrentYears;
                }
                else
                {
                    CurrentAge = CurrentYears - 1;
                }
        }


        int FutureAge = CurrentAge + 10;

        Console.WriteLine("Your current age is: " + CurrentAge);
        Console.WriteLine("After 10 Years your age would be: " + FutureAge);
    }
}
