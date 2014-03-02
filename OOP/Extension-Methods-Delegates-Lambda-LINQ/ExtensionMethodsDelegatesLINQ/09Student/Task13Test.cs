/*13. Select all students that have at least one mark Excellent (6) 
 * into a new anonymous class that has properties – FullName and Marks. Use LINQ.*/

namespace _09Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public static class Task13Test
    {
        public static void Test()
        {
            List<Student> sample = new List<Student>();

            sample.Add(new Student("Pesho", "Ivanov", 123, "028812", "pi@abv.bg", new List<int>() { 3, 3 }, 1));
            sample.Add(new Student("Stanislav", "Gevgirov", 124, "089512", "sg@gmail.com", new List<int>() { 4, 6 }, 2));
            sample.Add(new Student("Petar", "Tudjarov", 125, "089523", "pt@abv.bg", new List<int>() { 5, 4 }, 2));
            sample.Add(new Student("Manol", "Trifonov", 126, "029524", "mt@mail.bg", new List<int>() { 5, 3 }, 2));

            var selectStudentWithAtLeastOneSix =
                from s in sample
                where s.ContainMark(s.Marks, 6)
                select new { FullName = s.FirstName + " " + s.LastName, Marks = string.Join(",", s.Marks) };

            foreach (var st in selectStudentWithAtLeastOneSix)
            {
                Console.WriteLine(st.FullName + "'s marks: " + string.Join(", ", st.Marks));
            }
        }
    }
}
