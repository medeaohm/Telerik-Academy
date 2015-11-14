namespace DayOfTheWeekService
{
    using System;

    public class DayOfTheWeekService : IDayOfTheWeekService
    {
        public string GetDayOfTheWeek(DateTime date)
        {
            var culture = new System.Globalization.CultureInfo("bg-BG");
            return culture.DateTimeFormat.GetDayName(date.DayOfWeek);
        }
    }
}
