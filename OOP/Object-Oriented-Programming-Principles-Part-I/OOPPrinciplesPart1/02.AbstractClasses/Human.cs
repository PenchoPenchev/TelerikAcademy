namespace _02.AbstractClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public abstract class Human
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }

        public Human(string fname, string lname)
        {
            if (String.IsNullOrWhiteSpace(fname))
            {
                throw new ArgumentException("First name cannot be null or empty.");
            }

            if (String.IsNullOrWhiteSpace(lname))
            {
                throw new ArgumentException("Last name cannot be null or empty.");
            }
            
            this.FirstName = fname;
            this.LastName = lname;
        }
        
    }
}
