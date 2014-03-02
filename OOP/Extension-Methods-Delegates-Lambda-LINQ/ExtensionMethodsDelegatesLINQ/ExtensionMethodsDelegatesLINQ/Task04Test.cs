/*4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.*/

namespace TasksFrom1to7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public static class Task04Test
    {
        public static void Test()
        {
            List<Student> allStudentsWithAge = new List<Student>();

            allStudentsWithAge.Add(new Student("Pesho", "Ludiq", 20));
            allStudentsWithAge.Add(new Student("Kiro", "Pora", 15));
            allStudentsWithAge.Add(new Student("Sasho", "Mokroto", 24));
            allStudentsWithAge.Add(new Student("Ivan", "Toploto", 25));

            var studentsBetween18and24 =
                from st in allStudentsWithAge
                where (st.Age >= 18) && (st.Age <= 24)
                select st;

            Console.WriteLine("All students between 18 and 24 years old");
            foreach (var student in studentsBetween18and24)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Age);
            }
        }
    }
}
