/*We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
	Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
*/

namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    class MainClass
    {
        static void Main()
        {
            List<Student> students1 = new List<Student>();
            students1.Add(new Student("Kiril", "Nikolov", 1));
            students1.Add(new Student("Stamo", "Petkov", 2));
            students1.Add(new Student("Yordan", "Yordanov", 3));
            students1.Add(new Student("Boris", "Gutsev", 4));
            students1.Add(new Student("Martin", "Yankov", 5));
            students1.Add(new Student("Vladimir", "Georgiev", 6));
            students1.Add(new Student("Lina", "Ivanova", 7));

            List<Student> students2 = new List<Student>();
            students2.Add(new Student("Mihail", "Petrov", 1));
            students2.Add(new Student("Lyubomir", "Yanchev", 2));
            students2.Add(new Student("Nikolay", "Alexiev", 3));
            students2.Add(new Student("Konstantin", "Dikov", 4));
            students2.Add(new Student("Dimitar", "Todorov", 5));
            students2.Add(new Student("Tsvetan", "Ivanov", 6));
            students2.Add(new Student("Victor", "Ivanov", 7));

            List<Disciplines> donchoMinkovDisciplines = new List<Disciplines>();
            donchoMinkovDisciplines.Add(new Disciplines("C# Fundamentals Part I", 8, 8));
            donchoMinkovDisciplines.Add(new Disciplines("C# Fundamentals Part II", 8, 8));
            donchoMinkovDisciplines.Add(new Disciplines("Object-Oriented Programming", 8, 8));
            donchoMinkovDisciplines.Add(new Disciplines("JavaScript Part I", 8, 8));

            List<Disciplines> nikolayKostovDisciplines = new List<Disciplines>();
            nikolayKostovDisciplines.Add(new Disciplines("C# Fundamentals Part I", 10, 0));
            nikolayKostovDisciplines.Add(new Disciplines("C# Fundamentals Part II", 5, 5));
            nikolayKostovDisciplines.Add(new Disciplines("Object-Oriented Programming", 9, 9));
            nikolayKostovDisciplines.Add(new Disciplines("ASP.NET MVC", 8, 8));

            List<Disciplines> georgeGeorgievDisciplines = new List<Disciplines>();
            georgeGeorgievDisciplines.Add(new Disciplines("C# Fundamentals Part I", 10, 0));
            georgeGeorgievDisciplines.Add(new Disciplines("C# Fundamentals Part II", 5, 5));
            georgeGeorgievDisciplines.Add(new Disciplines("HTML5", 9, 9));
            georgeGeorgievDisciplines.Add(new Disciplines("CSS3", 8, 8));

            List<Disciplines> svetlinNakovDisciplines = new List<Disciplines>();
                svetlinNakovDisciplines.Add(new Disciplines("C# Fundamentals Part I", 10, 10));
                svetlinNakovDisciplines.Add(new Disciplines("C# Fundamentals Part II", 18, 3));
                svetlinNakovDisciplines.Add(new Disciplines("Object-Oriented Programming", 8, 1));
                svetlinNakovDisciplines.Add(new Disciplines("Knowledge Sharing and Teamwork", 10, 0));

            List<Teacher> teachers1 = new List<Teacher>();
            teachers1.Add(new Teacher("Doncho", "Minkov", donchoMinkovDisciplines, ""));
            teachers1.Add(new Teacher("Nikolay", "Kostov", nikolayKostovDisciplines, ""));

            List<Teacher> teachers2 = new List<Teacher>();
            teachers2.Add(new Teacher("George", "Georgiev", georgeGeorgievDisciplines, ""));
            teachers2.Add(new Teacher("Svetlin", "Nakov", svetlinNakovDisciplines, ""));

            List<SchoolClass> schoolClasses = new List<SchoolClass>();
            schoolClasses.Add(new SchoolClass("Ia", teachers1, students1, ""));
            schoolClasses.Add(new SchoolClass("Ib", teachers2, students2, ""));

            School telerikAcademy = new School("Telerik Academy", schoolClasses);

            Console.WriteLine(telerikAcademy);
        }
    }
}
