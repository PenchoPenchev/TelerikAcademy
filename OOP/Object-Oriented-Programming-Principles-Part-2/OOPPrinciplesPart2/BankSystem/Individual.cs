namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class Individual : Customer
    {
        private int age;

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            private set { gender = value; }
        }

        public Individual(string name, int age, string gender)
            : base(name)
        {
            if (age < 18)
            {
                throw new ArgumentOutOfRangeException("Individuals should not be less than 18 years old");
            }
            if (string.IsNullOrWhiteSpace(gender))
            {
                throw new ArgumentNullException("Gender should not be empty");
            }

            this.Age = age;
            this.Gender = gender;
        }
    }
}
