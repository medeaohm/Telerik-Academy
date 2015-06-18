namespace Cosmetics.Products
{
    using Contracts;
    using Common;

    public class Shampoo : Product, IShampoo
    {
        private uint milliliters;

        public Shampoo (string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Price = price * milliliters;
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters 
        {
            get { return this.milliliters; }
            private set
            {
                this.milliliters = value;
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Milliliters"));
            }
        }

        public UsageType Usage {get; private set;}

        public override string Print()
        {
            return base.Print() + string.Format("  * Quantity: {0} ml\n  * Usage: {1}", this.Milliliters, this.Usage);
        }
    }
}

