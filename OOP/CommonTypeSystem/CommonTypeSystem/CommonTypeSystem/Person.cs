/*4. Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.
*/

namespace CommonTypeSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            string result = "Student name: " + this.Name;
            result += this.Age != null ? "Age: " + this.Age : "Age: - not specified";
            return result;
        }
    }
}
