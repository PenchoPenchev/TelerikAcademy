/*15. Extract all Marks of the students that enrolled in 2006. 
 * (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).*/

namespace _09Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public static class Task15Test
    {
        public static void Test()
        {
            List<Student> sample = new List<Student>();

            sample.Add(new Student("Pesho", "Ivanov", 123306, "028812", "pi@abv.bg", new List<int>() { 3, 3 }, 1));
            sample.Add(new Student("Stanislav", "Gevgirov", 124407, "089512", "sg@gmail.com", new List<int>() { 4, 6 }, 2));
            sample.Add(new Student("Petar", "Tudjarov", 125406, "089523", "pt@abv.bg", new List<int>() { 5, 4 }, 2));
            sample.Add(new Student("Manol", "Trifonov", 126709, "029524", "mt@mail.bg", new List<int>() { 5, 3 }, 2));

            var selectStudentsFrom2006 =
                from s in sample
                where s.FN % 100 == 06
                select new { FullName = s.FirstName + " " + s.LastName, Marks = string.Join(",", s.Marks) };

            foreach (var st in selectStudentsFrom2006)
            {
                Console.WriteLine(st.FullName + "'s marks: " + string.Join(", ", st.Marks));
            }
        }
    }
}
