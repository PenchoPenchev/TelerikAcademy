using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public class Company : Customer
    {
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Company(string name, string address)
            : base(name)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentNullException("The address should not be empty");
            }

            this.Address = address;
        }
    }
}
