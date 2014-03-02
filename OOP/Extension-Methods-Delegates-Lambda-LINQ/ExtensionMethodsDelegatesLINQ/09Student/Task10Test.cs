/*10. Implement the previous using the same query expressed with extension methods.*/

namespace _09Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public static class Task10Test
    {
        public static void Test()
        {
            List<Student> sample = new List<Student>();

            sample.Add(new Student("Pesho", "Ivanov", 123, "088812", "pi@abv.bg", new List<int>() { 3, 3 }, 1));
            sample.Add(new Student("Stanislav", "Gevgirov", 124, "089512", "sg@abv.bg", new List<int>() { 4, 6 }, 2));
            sample.Add(new Student("Petar", "Tudjarov", 125, "089523", "pt@abv.bg", new List<int>() { 5, 4 }, 2));
            sample.Add(new Student("Manol", "Trifonov", 126, "089524", "mt@abv.bg", new List<int>() { 5, 3 }, 2));

            var selectionByGroupNumber = sample.FindAll(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

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
