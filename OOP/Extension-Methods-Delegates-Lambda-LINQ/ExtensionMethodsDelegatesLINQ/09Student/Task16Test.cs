/*16. * Create a class Group with properties GroupNumber and DepartmentName. 
 * Introduce a property Group in the Student class. 
 * Extract all students from "Mathematics" department. 
 * Use the Join operator.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Student
{
    public static class Task16Test
    {
        public static void Test()
        {
            List<Student> sample = new List<Student>();

            sample.Add(new Student("Pesho", "Ivanov", 123306, "028812", "pi@abv.bg", new List<int>() { 3, 3 }, 1));
            sample.Add(new Student("Stanislav", "Gevgirov", 124407, "089512", "sg@gmail.com", new List<int>() { 4, 6 }, 2));
            sample.Add(new Student("Petar", "Tudjarov", 125406, "089523", "pt@abv.bg", new List<int>() { 5, 4 }, 4));
            sample.Add(new Student("Manol", "Trifonov", 126709, "029524", "mt@mail.bg", new List<int>() { 5, 3 }, 3));
            
            List<Group> groups = new List<Group>()
            {
                new Group(1, "Physics"),
                new Group(2, "Arts"),
                new Group(3, "Mathematics"),
                new Group(4, "Law"),
                new Group(5, "Medicine"),
                new Group(6, "Biology"),
            };

            var joinClasses =
                from s in sample
                join g in groups on s.GroupNumber equals g.GroupNumber
                where g.DepartmentName == "Mathematics"
                select new { FullName = s.FirstName + " " + s.LastName, Department = g.DepartmentName };

            foreach (var jc in joinClasses)
            {
                Console.Write("Student names: {0} Department: {1}", jc.FullName, jc.Department);
            }
            Console.WriteLine();
        }
    }
}
