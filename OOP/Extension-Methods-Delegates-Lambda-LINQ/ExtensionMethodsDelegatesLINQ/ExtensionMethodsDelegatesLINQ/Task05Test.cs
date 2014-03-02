/*5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
 * by first name and last name in descending order. Rewrite the same with LINQ.*/

namespace TasksFrom1to7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public static class Task05Test
    {
        public static void Test()
        {
            List<Student> allStudentsWithAge = new List<Student>();

            allStudentsWithAge.Add(new Student("Pesho", "Ludiq", 20));
            allStudentsWithAge.Add(new Student("Kiro", "Pora", 15));
            allStudentsWithAge.Add(new Student("Sasho", "Mokroto", 24));
            allStudentsWithAge.Add(new Student("Ivan", "Toploto", 25));

            //Lambda expression
            var descOrderedStudentsLambda = allStudentsWithAge.OrderByDescending(fName => fName.FirstName)
                .ThenByDescending(lName => lName.LastName).Select(st => st.FirstName + " " + st.LastName);

            Console.WriteLine("Lambda expression");
            foreach (var student in descOrderedStudentsLambda)
            {
                Console.WriteLine(student);
            }

            //LINQ variant
            var descOrderedStudentsLINQ =
                from st in allStudentsWithAge
                orderby st.FirstName descending, st.LastName descending
                select st;

            Console.WriteLine("LINQ");
            foreach (var student in descOrderedStudentsLINQ)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
