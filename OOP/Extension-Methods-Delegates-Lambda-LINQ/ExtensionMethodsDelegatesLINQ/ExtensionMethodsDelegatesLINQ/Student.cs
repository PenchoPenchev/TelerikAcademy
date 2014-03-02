/*3. Write a method that from a given array of students finds all students 
 * whose first name is before its last name alphabetically. Use LINQ query operators.*/

namespace TasksFrom1to7
{
    using System;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, int age)
            : this(firstName, lastName)
        {
            this.Age = age;
        }
    }
}
