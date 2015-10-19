namespace CreateNorthwindTwinDatabase
{
    using System;
    using EntityFrameworkNorthwind;

    public class Program
    {
        public static void Main()
        {
            NorthwindEntities context = new NorthwindEntities();
            context.Database.Create();
            
        }
    }
}
