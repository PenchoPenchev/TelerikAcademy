namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public abstract class Account : IDepositable
    {
        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            private set { customer = value; }
        }

        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        private decimal interestRate;

        public decimal InterestRate
        {
            get { return interestRate; }
            private set { interestRate = value; }
        }

        private int numberOfMonths;

        public int NumberOfMonths
        {
            get { return numberOfMonths; }
            private set { numberOfMonths = value; }
        }
        

        public Account(Customer customer, decimal balance, decimal interest, int period)
        {
            if (balance < 0)
            {
                throw new ArgumentOutOfRangeException("Customer balance should not be negative");
            }
            if (interest < 0)
            {
                throw new ArgumentOutOfRangeException("Interest rate should not be negative");
            }
            if (numberOfMonths < 0)
            {
                throw new ArgumentOutOfRangeException("Number of months should not be negative");
            }

            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interest;
            this.NumberOfMonths = period;
        }

        public abstract decimal CalcInterestAmount();

        public abstract void Deposit(decimal money, Customer customer);
    }
}
