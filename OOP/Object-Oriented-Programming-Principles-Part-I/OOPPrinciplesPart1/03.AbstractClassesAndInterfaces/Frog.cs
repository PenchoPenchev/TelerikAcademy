namespace _03.AbstractClassesAndInterfaces
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Sex gender)
            : base(name, age, gender)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("Kvak!");
        }
    }
}
