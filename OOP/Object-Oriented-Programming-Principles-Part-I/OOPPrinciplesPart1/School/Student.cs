namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class Student : Person
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Student(string firstName, string lastName, int id)
            : base(firstName, lastName)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            string printStudentInfo = "ID " + this.id + " Name " + base.ToString(); 
            return printStudentInfo;
        }
    }
}
