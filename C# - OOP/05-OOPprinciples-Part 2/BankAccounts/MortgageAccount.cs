namespace BankAccounts
{
    using System;

    public class MortgageAccount : Account, IDrawable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base (customer, balance, monthlyInterestRate)
        {

        }

        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("You cannot withdraw more than the balance of the account.");
            }
            this.Balance -= amount;
        }

        public override decimal CalculateInterestAmount(int numOfMonths)
        {
            if (this.Cust is Individual)
            {
                numOfMonths -= 6;
            }
            else if (this.Cust is Company)
            {
                numOfMonths -= 12;
            }
            if (numOfMonths <= 0)
            {
                return 0M;
            }
            return base.CalculateInterestAmount(numOfMonths);
        }

        public override string ToString()
        {
            return "MORGAGE" + " - " + base.ToString();
        }
    }      
}

