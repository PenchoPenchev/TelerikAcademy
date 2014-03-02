/*11. Extract all students that have email in abv.bg. Use string methods and LINQ.*/

namespace _09Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Task11Test
    {
        public static void Test()
        {
            List<Student> sample = new List<Student>();

            sample.Add(new Student("Pesho", "Ivanov", 123, "088812", "pi@abv.bg", new List<int>() { 3, 3 }, 1));
            sample.Add(new Student("Stanislav", "Gevgirov", 124, "089512", "sg@gmail.com", new List<int>() { 4, 6 }, 2));
            sample.Add(new Student("Petar", "Tudjarov", 125, "089523", "pt@abv.bg", new List<int>() { 5, 4 }, 2));
            sample.Add(new Student("Manol", "Trifonov", 126, "089524", "mt@mail.bg", new List<int>() { 5, 3 }, 2));

            var selectStudentsInAbv =
                from s in sample
                where s.Email.EndsWith("abv.bg")
                select s;

            foreach (var st in selectStudentsInAbv)
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
