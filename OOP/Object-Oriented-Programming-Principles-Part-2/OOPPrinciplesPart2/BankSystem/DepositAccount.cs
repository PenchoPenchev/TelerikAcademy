using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public class DepositAccount : Account, IWithDrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interest, int period)
            : base(customer, balance, interest, period)
        {

        }

        public override void Deposit(decimal money, Customer customer)
        {
            if (money < 0)
            {
                throw new ArgumentOutOfRangeException("Deposit sum should be greater than zero");
            }

            new DepositAccount(this.Customer, this.Balance + money, this.InterestRate, this.NumberOfMonths);
        }

        public void WithDraw(decimal money, Customer customer)
        {
            if (money < 0)
            {
                throw new ArgumentOutOfRangeException("Deposit sum should be greater than zero");
            }

            if ((this.Balance - money) < 0)
            {
                throw new ArgumentOutOfRangeException("Not enough money for requested transaction");
            }

            new DepositAccount(this.Customer, this.Balance - money, this.InterestRate, this.NumberOfMonths);
        }

        public override decimal CalcInterestAmount()
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                decimal interestAmount = this.InterestRate * this.NumberOfMonths;

                return interestAmount;
            }
        }
    }
}
