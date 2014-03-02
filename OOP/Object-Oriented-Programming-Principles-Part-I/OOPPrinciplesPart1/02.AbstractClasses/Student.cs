namespace _02.AbstractClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class Student : Human
    {
        private double grade;

        public double Grade
        {
            get { return grade; }
            private set { grade = value; }
        }

        public Student(string fname, string lname, double grade)
            : base(fname, lname)
        {
            if (grade < 2 || grade > 6)
            {
                throw new ArgumentOutOfRangeException("The grade should be in the range 2.00 - 6.00");
            }
            this.Grade = grade;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " : " + this.grade;
        }
    }
}
