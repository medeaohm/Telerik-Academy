namespace BankAccounts
{
    using System;

    public class DepositAccount : Account, IDrawable, IDepositable
    {
        public DepositAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
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

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }


        public override decimal CalculateInterestAmount(int numOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000M)
            {
                return 0M;
            }
            return base.CalculateInterestAmount(numOfMonths);
        }

        public override string ToString()
        {
            return "DEPOSIT" + " - " + base.ToString();
        }
    }
}
