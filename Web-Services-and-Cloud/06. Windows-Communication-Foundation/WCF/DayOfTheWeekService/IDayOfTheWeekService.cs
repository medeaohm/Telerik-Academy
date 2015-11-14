namespace DayOfTheWeekService
{
    using System;
    using System.ServiceModel;

    [ServiceContract]
    public interface IDayOfTheWeekService
    {
        [OperationContract]
        string GetDayOfTheWeek(DateTime date);
    }
}
