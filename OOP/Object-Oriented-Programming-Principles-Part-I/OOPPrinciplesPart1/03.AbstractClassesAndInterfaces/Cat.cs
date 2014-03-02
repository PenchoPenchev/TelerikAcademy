namespace _03.AbstractClassesAndInterfaces
{
    using System;

    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Sex gender)
            : base(name, age, gender)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("Mqu!");
        }
    }
}
