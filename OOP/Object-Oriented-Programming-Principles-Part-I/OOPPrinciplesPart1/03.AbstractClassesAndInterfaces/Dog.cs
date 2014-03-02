namespace _03.AbstractClassesAndInterfaces
{
    using System;
    
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, Sex gender)
            : base(name, age, gender)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("Bau!");
        }
    }
}
