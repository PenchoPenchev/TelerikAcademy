namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class Disciplines
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int NumberOfLectures
        {
            get { return numberOfLectures; }
            private set { numberOfLectures = value; }
        }

        public int NumberOfExercises
        {
            get { return numberOfExercises; }
            private set { numberOfExercises = value; }
        }

        public Disciplines(string name, int lectures, int exercises)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Discipline title cannot be null or empty.");
            }
            if (lectures < 0)
            {
                throw new ArgumentException("Lectures could not be negative.");
            }
            if (exercises < 0)
            {
                throw new ArgumentException("Exercises could not be negative.");
            }

            this.Name = name;
            this.NumberOfLectures = lectures;
            this.NumberOfExercises = exercises;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1} lectures, {2} exercises", this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}
