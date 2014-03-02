/*19. Create a program that extracts all students grouped by GroupName and then prints them to the console. 
 Use extension methods - Lambda expression*/

namespace Tasks18and19
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public static class Task19Test
    {
        public static void Test()
        {
            List<Student> sample = new List<Student>();

            sample.Add(new Student("Pesho Ivanov", "Mathematics"));
            sample.Add(new Student("Stanislav Gevgirov", "Physics"));
            sample.Add(new Student("Petar Tudjarov", "Mathematics"));
            sample.Add(new Student("Manol Trifonov", "Medicine"));
            sample.Add(new Student("Mima Zafirova", "Medicine"));
            sample.Add(new Student("Todor Kolev", "Arts"));

            var queryGroupBy = sample.GroupBy(x => x.GroupName).OrderBy(x => x.Key);

            foreach (var currentGroup in queryGroupBy)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(currentGroup.Key);
                Console.ResetColor();

                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.StudentName);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
