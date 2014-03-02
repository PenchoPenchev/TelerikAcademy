using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class SchoolClass
    {
        private string id;
        private List<Teacher> setOfTeachers;
        private List<Student> setOfStudents;
        private string comments;

        public string Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public string Comments
        {
            get { return this.comments; }
            private set { this.comments = value; }
        }

        public List<Teacher> SefOfTeachers
        {
            get { return this.setOfTeachers; }
            private set { this.setOfTeachers = value; }
        }

        public SchoolClass(string id, List<Teacher> teachers, List<Student> students, string comments)
        {
            this.Id = id;
            this.SefOfTeachers = new List<Teacher>(teachers);
            this.SetOfStudents = new List<Student>(students);
            this.Comments = comments;
        }

        public List<Student> SetOfStudents
        {
            get { return setOfStudents; }
            set { setOfStudents = value; }
        }
    }
}
