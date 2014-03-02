namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class Teacher : Person
    {
        private List<Disciplines> setOfDisciplines;
        private string comments;

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public List<Disciplines> SetOfDisciplines
        {
            get { return this.setOfDisciplines; }
            set { this.setOfDisciplines = value; }
        }

        public Teacher(string firstName, string lastName, List<Disciplines> disciplines, string comments)
            : base(firstName, lastName)
        {
            this.SetOfDisciplines = new List<Disciplines>(disciplines);
            this.Comments = comments;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("Teacher: {0}", base.ToString());

            builder.Append("\r\nCourses:");

            builder.AppendFormat("\r\n{0}", string.Join(",", this.SetOfDisciplines));
            
            return builder.ToString();
        }
    }
}
