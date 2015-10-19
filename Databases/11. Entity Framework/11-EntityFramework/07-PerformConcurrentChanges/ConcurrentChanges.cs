namespace ConcurrentChanges
{
    using System.Linq;
    using EntityFrameworkNorthwind;
    using AddDeleteModify;

    public class ConcurrentChanges
    {
        public static void Main()
        {
            AddDeleteModify.AddNewCustomer();
            AddDeleteModify.PrintLastCustomer();

            using (var db = new NorthwindEntities())
            {
                Customer customerToBeModified = db.Customers.FirstOrDefault(c => c.CustomerID == "ZZZZZ");
                customerToBeModified.Country = "Italy";

                using (var db2 = new NorthwindEntities())
                {
                    //Customer customerToBeModified2 = db2.Customers.FirstOrDefault(c => c.CustomerID == "ZZZZZ");
                    customerToBeModified.Country = "France";
//                    db2.SaveChanges();
                }

                db.SaveChanges();
            }

            

            AddDeleteModify.PrintLastCustomer();
        }
    }
}
