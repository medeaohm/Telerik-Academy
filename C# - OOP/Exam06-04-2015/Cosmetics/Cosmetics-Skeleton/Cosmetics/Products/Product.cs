namespace Cosmetics.Products
{
    using System.Text;

    using Contracts;
    using Common;

    public abstract class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;

        public Product (string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                this.name = value;
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, value));
                Validator.CheckIfStringLengthIsValid(name, 10, 3, string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", 3, 10));
            }
        }

        public string Brand
        {
            get { return this.brand; }
            protected set 
            {
                this.brand = value;
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, value));
                Validator.CheckIfStringLengthIsValid(value, 10, 2, string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", 2, 10));        
            }
        }

        public decimal Price 
        {
            get { return this.price; }
            protected set
            {
                this.price = value;
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Price"));
            }
        }

        public Common.GenderType Gender { get; protected set; }

        public virtual string Print()
        {
            var output = new StringBuilder();
            output.AppendFormat("- {0} - {1}:\n", this.Brand, this.Name);
            output.AppendFormat("  * Price: ${0}\n  * For gender: {1}\n", this.Price, this.Gender);
            return output.ToString();
        }
    }
}

