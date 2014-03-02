namespace Tasks18and19
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class Student
    {
        public string StudentName { get; private set; }
        public string GroupName { get; private set; }

        public Student(string stName, string grName)
        {
            this.StudentName = stName;
            this.GroupName = grName;
        }
    }
}
