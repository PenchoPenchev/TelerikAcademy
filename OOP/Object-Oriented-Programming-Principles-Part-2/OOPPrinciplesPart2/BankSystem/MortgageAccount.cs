namespace BankSystem
{
    using System;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interest, int period)
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

            new MortgageAccount(this.Customer, this.Balance - money, this.InterestRate, this.NumberOfMonths);
        }

        public override decimal CalcInterestAmount()
        {
            decimal interestAmount = 0;

            if (this.NumberOfMonths <= 6 && Customer is Individual)
            {
                interestAmount = 0;
            }
            else if (this.NumberOfMonths <= 12 && Customer is Company)
            {
                interestAmount = (this.InterestRate / 2) * this.NumberOfMonths;
            }
            else if (this.NumberOfMonths > 12 && Customer is Company)
            {
                int monthsWithoutPrivilages = this.NumberOfMonths - 12;
                interestAmount = (this.InterestRate / 6) + (monthsWithoutPrivilages * this.InterestRate);
            }

            return interestAmount;
        }
    }
}
