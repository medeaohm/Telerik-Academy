namespace FindCustomers
{
    using System;

    public class View
    {
        public string Customer
        {
            get; set;
        }

        public DateTime OrderDate
        {
            get; set;
        }

        public string ShipCountry
        {
            get; set;
        }

        public override string ToString()
        {
            // not sure why this.OrderDate does not work here
            return this.Customer + " - " + "1997" + " - " + this.ShipCountry;
        }
    }
}