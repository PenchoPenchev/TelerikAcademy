/*9. Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. 
 * Create a List<Student> with sample students. 
 * Select only the students that are from group number 2. 
 * Use LINQ query. Order the students by FirstName.*/

namespace _09Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string fName, string lName, int fn, string tel, string email, List<int> marks, int grNumber)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = grNumber;
        }

        public bool ContainMark(List<int> marks, int mark)
        {
            foreach (var m in marks)
            {
                if (m == mark)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
