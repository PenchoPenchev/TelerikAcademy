namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interest, int period)
            : base(customer, balance, interest, period)
        {

        }
        
        public override void Deposit(decimal money, Customer customer)
        {
            if (money < 0)
            {
                throw new ArgumentOutOfRangeException("Deposit sum should be greater than zero");
            }

            if ((this.Balance - money) < 0)
            {
                throw new ArgumentOutOfRangeException("Deposit more than required");
            }

            new LoanAccount(this.Customer, this.Balance - money, this.InterestRate, this.NumberOfMonths);
        }

        public override decimal CalcInterestAmount()
        {
            int monthsLeft = this.NumberOfMonths;

            if (this.NumberOfMonths <= 3 && Customer is Individual)
            {
                return 0;
            }
            else if (this.NumberOfMonths <= 2 && Customer is Company)
            {
                return 0;
            }
            else if (this.NumberOfMonths > 3 && Customer is Individual)
            {
                monthsLeft -= 3;
            }
            else if (this.NumberOfMonths > 2 && Customer is Company)
            {
                monthsLeft -= 2;
            }

            decimal interestAmount = this.InterestRate * monthsLeft;

            return interestAmount;
        }
    }
}
