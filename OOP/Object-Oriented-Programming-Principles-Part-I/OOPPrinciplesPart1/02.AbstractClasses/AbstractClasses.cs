/*Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in descending order. Merge the lists and sort them by first name and last name.
*/

namespace _02.AbstractClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    class AbstractClasses
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Pesho", "Ivanov", 5.5),
                new Student("Albena", "Vasileva", 3.6),
                new Student("Maria", "Grigorova", 5.8),
                new Student("Ivan", "Georgiev", 6.00),
                new Student("Miroslav", "Georgiev", 5.3),
                new Student("Ilian", "Iliev", 5.7),
                new Student("Boqn", "Simeonov", 4.8),
                new Student("Ivan", "Simeonov", 3.2),
                new Student("Irina", "Ratz", 4.7),
                new Student("Teodora", "Angelova", 5.00)
            };

            var studentsByGrade = students.OrderBy(x => x.Grade);

            Console.WriteLine("Students");
            Console.WriteLine();

            foreach (var student in studentsByGrade)
            {
                Console.WriteLine(student.ToString());
            }

            List<Worker> workers = new List<Worker>
            {
                new Worker("Pesho", "Ivanov", 75, 8),
                new Worker("Albena", "Vasileva", 70, 8),
                new Worker("Maria", "Grigorova", 79, 6),
                new Worker("Ivan", "Georgiev", 100, 8),
                new Worker("Miroslav", "Georgiev", 90, 12),
                new Worker("Ilian", "Iliev", 150, 8),
                new Worker("Boqn", "Simeonov", 50, 4),
                new Worker("Ivan", "Simeonov", 65, 6),
                new Worker("Irina", "Ratz", 130, 8),
                new Worker("Teodora", "Angelova", 180, 8)
            };

            var workersWithMoneysPerHour = workers.OrderByDescending(x => x.MoneyPerHour());

            Console.WriteLine();
            Console.WriteLine("Workers");
            Console.WriteLine();

            foreach (var worker in workersWithMoneysPerHour)
            {
                Console.WriteLine(worker.ToString());
            }
        }
    }
}
