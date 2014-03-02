namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class School
    {
        private string name;

        private List<SchoolClass> classes;

        public List<SchoolClass> Classes
        {
            get { return classes; }
            set { classes = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public School(string name, List<SchoolClass> classes)
        {
            this.Name = name;
            this.Classes = classes;
        }

        public override string ToString()
        {
            StringBuilder schoolInfoBuilder = new StringBuilder();

            schoolInfoBuilder.AppendFormat("School: {0}", this.Name);

            foreach (SchoolClass schoolClass in this.Classes)
            {
                schoolInfoBuilder.AppendFormat("\r\n{0}", schoolClass.Id);
                foreach (var teacher in schoolClass.SefOfTeachers)
                {
                    schoolInfoBuilder.AppendFormat("\r\n{0}", teacher.ToString());
                }

                schoolInfoBuilder.AppendFormat("\r\n{0}", string.Join(",", schoolClass.SetOfStudents));
            }

            return schoolInfoBuilder.ToString();
        }
    }
}
