namespace FindSalesByRegionAndPeriod
{
    using System;
    using System.Linq;
    using EntityFrameworkNorthwind;

    public class FindSales
    {
        const string ShipRegion = "RJ";

        // Write a method that finds all the sales by specified region and period (start / end dates).
        public static void Main()
        {
            DateTime StartDate = new DateTime(1996, 01, 01);
            DateTime EndDate = new DateTime(1998, 01, 01);

            NorthwindEntities db = new NorthwindEntities();

            var sales = db.Orders
                .Where(o => o.ShipRegion == ShipRegion &&
                            o.OrderDate <= EndDate &&
                            o.OrderDate >= StartDate)
                .ToList();

            foreach (var sale in sales)
            {
                Console.WriteLine("{0} - {1} - {2}", sale.OrderID, sale.ShipRegion, sale.OrderDate);
            }
        }
    }
}
