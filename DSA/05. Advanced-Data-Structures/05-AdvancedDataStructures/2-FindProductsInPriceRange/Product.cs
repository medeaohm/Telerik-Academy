namespace FindProductsInPriceRange
{
    using System;

    public class Product : IComparable<Product>
    {

        public Product(string name, decimal price)
        {
            this.Price = price;
            this.Name = name;
        }

        public string Name
        {
            get; set;
        }

        public decimal Price
        {
            get; set;
        }


        public int CompareTo(Product other)
        {
            return (int)(this.Price - other.Price);
        }

        public override string ToString()
        {
            return "Product: " + this.Name + " - Price: " + this.Price.ToString("F2");
        }
    }
}
