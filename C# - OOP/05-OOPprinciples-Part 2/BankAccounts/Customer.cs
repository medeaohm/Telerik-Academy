namespace BankAccounts
{
    using System;

    public abstract class Customer
    {
        public string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name is mandatory!");
                }
                this.name = value;
            }
        }
    }
}
