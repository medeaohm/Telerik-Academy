namespace AddDeleteModify
{
    using System;
    using System.Linq;
    using EntityFrameworkNorthwind;

    public class AddDeleteModify
    {
        public static void Main()
        {
            AddNewCustomer();
            Console.WriteLine("New Cutomer added to database");
            PrintLastCustomer();

            ModifyExistingCustomer();
            Console.WriteLine("Customer modified");
            PrintLastCustomer();

            DeleteCustomer();
            Console.WriteLine("Customer deleted from database");
            PrintLastCustomer();
        }

        public static void PrintLastCustomer()
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            var lastCustomer =
                (from c in northwindEntities.Customers
                 orderby c.CustomerID descending
                 select c).Take(1).ToList();
            Console.WriteLine("Last customer:");
            Console.WriteLine("{0}. {1}", lastCustomer[0].CustomerID, lastCustomer[0].Country);
            Console.WriteLine();
        }

        public static void ModifyExistingCustomer()
        {
            NorthwindEntities db = new NorthwindEntities();
            Customer customerToBeModified = db.Customers.FirstOrDefault(c => c.CustomerID == "ZZZZZ");
            customerToBeModified.Country = "Italy";
            db.SaveChanges();
        }

        public static void DeleteCustomer()
        {
            NorthwindEntities db = new NorthwindEntities();
            Customer customerToBeDeleted = db.Customers.FirstOrDefault(c => c.CustomerID == "ZZZZZ");
            db.Customers.Remove(customerToBeDeleted);
            db.SaveChanges();
        }

        public static void AddNewCustomer()
        {
            NorthwindEntities db = new NorthwindEntities();
            var newCustomer = new Customer
            {
                CustomerID = "ZZZZZ",
                CompanyName = "Telerik",
                ContactName = "Mariika",
                ContactTitle = "Junior Developer",
                Address = "mladost",
                City = "Sofia",
                Country = "Bulgaria",
                Phone = "030-0023002",
                Fax = "030-0023003"
            };

            db.Customers.Add(newCustomer);
            db.SaveChanges();
        }
    }
}
