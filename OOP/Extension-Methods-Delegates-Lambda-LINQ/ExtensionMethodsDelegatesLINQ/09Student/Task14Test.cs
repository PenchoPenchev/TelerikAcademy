/*14. Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.*/

namespace _09Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Task14Test
    {
        public static void Test()
        {
            List<Student> sample = new List<Student>();

            sample.Add(new Student("Pesho", "Ivanov", 123, "028812", "pi@abv.bg", new List<int>() { 3, 3, 4 }, 1));
            sample.Add(new Student("Stanislav", "Gevgirov", 124, "089512", "sg@gmail.com", new List<int>() { 4, 6, 4 }, 2));
            sample.Add(new Student("Petar", "Tudjarov", 125, "089523", "pt@abv.bg", new List<int>() { 5, 4 }, 2));
            sample.Add(new Student("Manol", "Trifonov", 126, "029524", "mt@mail.bg", new List<int>() { 5, 3 }, 2));

            List<Student> studentsWithExact2Marks = sample.FindAll(x => x.Marks.Count == 2);

            foreach (var st in studentsWithExact2Marks)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + "'s marks: " + string.Join(", ", st.Marks));
            }
        }

        //Second way
        public static List<Student> FindStudentWithExactNumberOfMarks(this List<Student> list, int numberOfMarks)
        {
            var selectionByGroupNumber =
                from s in list
                where s.Marks.Count == numberOfMarks
                select s;

            return selectionByGroupNumber.ToList();
        }
    }
}
