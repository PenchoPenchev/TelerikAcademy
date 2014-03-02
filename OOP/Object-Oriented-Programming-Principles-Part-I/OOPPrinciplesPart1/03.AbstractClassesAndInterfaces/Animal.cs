namespace _03.AbstractClassesAndInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public abstract class Animal
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Sex Gender { get; private set; }
        
        public Animal(string name, int age, Sex gender)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("The name should not be null or white space");
            }
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("The age could be negative");
            }
            
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public static void CalcAverageAge(List<Animal> animals)
        {
            var averageAge = animals.Average(x => x.Age);
            var animalType = animals[0].GetType().Name;

            Console.WriteLine("Average age of {0}s is {1}", animalType, averageAge);
        }
    }
}
