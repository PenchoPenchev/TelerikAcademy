/*1. Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
*/

/*2. Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
*/

/*3. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
*/

namespace CommonTypeSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string address;
        private string phoneNumber;
        private string email;
        private ushort course;
        private Universities university;
        private Faculties faculty;
        private Specialties specialty;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string SSN
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public ushort Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public Universities University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public Faculties Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        public Specialties Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }
        
        public Student(string fName, string mName, string lName, string ssn, string addr, string number,
            string mail, ushort course, Universities uni, Faculties facult, Specialties specialty)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = ssn;
            this.Address = addr;
            this.PhoneNumber = number;
            this.Email = mail;
            this.Course = course;
            this.University = uni;
            this.Faculty = facult;
            this.Specialty = specialty;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("First name: " + this.FirstName);
            result.AppendLine("Middle name: " + this.MiddleName);
            result.AppendLine("Last name: " + this.LastName);
            result.AppendLine("SSN: " + this.SSN);
            result.AppendLine("Address: " + this.Address);
            result.AppendLine("Phone number: " + this.PhoneNumber);
            result.AppendLine("E-mail: " + this.Email);
            result.AppendLine("Course: " + this.Course.ToString());
            result.AppendLine("University: " + this.University);
            result.AppendLine("Faculty: " + this.Faculty);
            result.AppendLine("Specialty: " + this.Specialty);

            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (!object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (!object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }

            if (!object.Equals(this.LastName, student.LastName))
            {
                return false;
            }

            if (!object.Equals(this.SSN, student.SSN))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            Student clone = new Student
            (
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.SSN,
                this.Address,
                this.PhoneNumber,
                this.Email,
                this.Course,
                this.University,
                this.Faculty,
                this.Specialty
            );

            return clone;
        }



        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return string.Compare(this.FirstName, student.FirstName);
            }

            if (this.MiddleName != student.MiddleName)
            {
                return string.Compare(this.middleName, student.FirstName);
            }

            if (this.LastName != student.LastName)
            {
                return string.Compare(this.LastName, student.LastName);
            }

            if (this.SSN != student.SSN)
            {
                return -1;
            }
            
            return 0;
        }
    }
}
