namespace BankSystem
{
    using System;
    
    public class Customer
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public Customer(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name should not be empty");
            }

            this.Name = name;
        }
    }
}
