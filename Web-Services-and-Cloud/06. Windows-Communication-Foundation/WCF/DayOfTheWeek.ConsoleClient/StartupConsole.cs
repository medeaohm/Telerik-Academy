namespace Client
{
    using System;

    using DayOfTheWeek.ConsoleClient.ServiceReference1;

    public class StartupConsole
    {
        public static void Main()
        {
            // the servise shoul be running - DayOfWeekService -> DayOfWeekService.svc -> view in browser
            DayOfTheWeekServiceClient client = new DayOfTheWeekServiceClient();
            using (client)
            {
                var result = client.GetDayOfTheWeek(DateTime.Now);
                Console.WriteLine(result);
            }
        }
    }
}
