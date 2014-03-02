namespace _02.AbstractClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class Worker : Human
    {
        private double weekSalary;

        public double WeekSalary
        {
            get { return weekSalary; }
            private set { weekSalary = value; }
        }

        private double workHoursPerDay;

        public double WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            private set { workHoursPerDay = value; }
        }

        public Worker(string fname, string lname, double weekSalary, double hoursPerDay)
            : base(fname, lname)
        {
            if (weekSalary < 0)
            {
                throw new ArgumentException("The salary could not be negative.");
            }

            if (hoursPerDay < 0)
            {
                throw new ArgumentException("Hours could not be negative.");
            }

            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = hoursPerDay;
        }

        public double MoneyPerHour()
        {
            double daysOfWeek = 5;
            double salaryPerDay = this.WeekSalary / daysOfWeek; 
            double result = salaryPerDay / this.WorkHoursPerDay;
            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0} {1}", this.FirstName,this.LastName);
            result.AppendFormat("\r\nWeek salary = {0}, Work hours per day = {1}, salary per day = {2}",
                this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour().ToString());
            
            return result.ToString();
        }
    }
}
