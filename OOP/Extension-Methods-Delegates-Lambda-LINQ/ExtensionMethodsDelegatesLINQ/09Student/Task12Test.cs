/*12. Extract all students with phones in Sofia. Use LINQ.*/

namespace _09Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Task12Test
    {
        public static void Test()
        {
            List<Student> sample = new List<Student>();

            sample.Add(new Student("Pesho", "Ivanov", 123, "028812", "pi@abv.bg", new List<int>() { 3, 3 }, 1));
            sample.Add(new Student("Stanislav", "Gevgirov", 124, "089512", "sg@gmail.com", new List<int>() { 4, 6 }, 2));
            sample.Add(new Student("Petar", "Tudjarov", 125, "089523", "pt@abv.bg", new List<int>() { 5, 4 }, 2));
            sample.Add(new Student("Manol", "Trifonov", 126, "029524", "mt@mail.bg", new List<int>() { 5, 3 }, 2));

            var selectPhonesInSofia =
                from s in sample
                where s.Tel.StartsWith("02")
                select s;

            foreach (var st in selectPhonesInSofia)
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
