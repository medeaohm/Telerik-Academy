namespace FindCustomers
{
    using System;
    using System.Linq;
    using EntityFrameworkNorthwind;

    public class FindCustomers
    {
        public static void Main()
        {
            FindGivenCustomers();

            Console.WriteLine("And now with native SQL queries...");

            FindGivenCustomersNativeSQLQueruies();
        }


        public static void FindGivenCustomers()
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            var customers =
                northwindEntities.Customers
                .Join(northwindEntities.Orders,
                    (c => c.CustomerID),
                    (o => o.CustomerID),
                    (c, o) => new
                    {
                        CustomerName = c.ContactName,
                        OrderYear = o.OrderDate.Value.Year,
                        o.ShipCountry
                    }
                )
                .ToList()
                .FindAll(c => c.OrderYear == 1997 && c.ShipCountry == "Canada")
                .ToList();

            Console.WriteLine("All customers who have orders made in 1997 and shipped to Canada:");
            foreach (var cust in customers)
            {
                Console.WriteLine("{0} - {1} - {2}", cust.CustomerName, cust.OrderYear, cust.ShipCountry);
            }
            Console.WriteLine();
        }

        private static void FindGivenCustomersNativeSQLQueruies()
        {
            const string nativeSqlQuery =
                "SELECT c.ContactName AS [Customer], o.OrderDate [Order Year], o.ShipCountry " +
                "FROM Customers c " +
                "JOIN Orders o " +
                "ON c.CustomerID = o.CustomerID " +
                "WHERE YEAR(o.OrderDate) = 1997 AND o.ShipCountry = 'Canada'";

            NorthwindEntities db = new NorthwindEntities();
            var customers = db.Database.SqlQuery<View>(nativeSqlQuery);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
