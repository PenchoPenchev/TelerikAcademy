/*3. Write a method that from a given array of students finds all students 
 * whose first name is before its last name alphabetically. Use LINQ query operators.*/

namespace TasksFrom1to7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Task03Test
    {
        public static void Test()
        {
            List<Student> allStudents = new List<Student>();

            allStudents.Add(new Student("Pesho", "Ludiq"));
            allStudents.Add(new Student("Kiro", "Pora"));
            allStudents.Add(new Student("Sasho", "Mokroto"));
            allStudents.Add(new Student("Ivan", "Toploto"));

            var firstNameBeforeLastName =
                from st in allStudents
                where st.FirstName[0] < st.LastName[0] //Because in ASCII table small letters starts from 97 and grows up I'm using  <
                select st;

            Console.WriteLine("All students whose first name is before last name alphabetically");

            foreach (var student in firstNameBeforeLastName)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

        }
    }
}
