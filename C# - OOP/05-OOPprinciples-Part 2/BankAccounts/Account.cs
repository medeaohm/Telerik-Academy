namespace BankAccounts
{
    using System;

    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal monthlyInterestRate;

        public Account(Customer customer, decimal balance, decimal monthlyInterestRate)
        {
            this.Cust = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
        }

        public Customer Cust
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal MonthlyInterestRate
        {
            get { return this.monthlyInterestRate; }
            set { this.monthlyInterestRate = value; }
        }

        public virtual decimal CalculateInterestAmount(int numOfMonths)
        {
            if (numOfMonths < 0)
            {
                throw new ArgumentException("Number of months cannot be negative!");
            }
            return numOfMonths * this.monthlyInterestRate;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1:0.00}", this.Cust.Name, this.Balance);
        }
    }
}
