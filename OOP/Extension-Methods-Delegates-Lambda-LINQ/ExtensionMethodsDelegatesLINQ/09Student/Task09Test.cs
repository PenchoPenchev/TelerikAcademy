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
    
    public static class Task09Test
    {
        public static void Test()
        {
            List<Student> sample = new List<Student>();

            sample.Add(new Student("Pesho", "Ivanov", 123, "088812", "pi@abv.bg", new List<int>() { 3, 3 }, 1));
            sample.Add(new Student("Stanislav", "Gevgirov", 124, "089512", "sg@abv.bg", new List<int>() { 4, 6 }, 2));
            sample.Add(new Student("Petar", "Tudjarov", 125, "089523", "pt@abv.bg", new List<int>() { 5, 4 }, 2));
            sample.Add(new Student("Manol", "Trifonov", 126, "089524", "mt@abv.bg", new List<int>() { 5, 3 }, 2));

            var selectionByGroupNumber =
                from s in sample
                where s.GroupNumber == 2
                orderby s.FirstName
                select s;

            foreach (var st in selectionByGroupNumber)
            {
                StringBuilder marks = new StringBuilder();

                foreach (var mark in st.Marks)
                {
                    marks.Append(mark + " ");
                }
                Console.WriteLine(st.FirstName + " " + st.LastName + " " + st.FN + " " + marks
                    + "" + st.Tel + " " + st.Email + " " + st.GroupNumber);
            }
        }
    }
}
