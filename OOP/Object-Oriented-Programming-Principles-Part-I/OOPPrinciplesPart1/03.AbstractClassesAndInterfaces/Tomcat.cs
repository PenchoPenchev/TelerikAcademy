namespace _03.AbstractClassesAndInterfaces
{
    using System;

    public class Tomcat : Cat
    {
        
        public Tomcat(string name, int age, Sex gender)
            : base(name, age, Sex.Male)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("Baby tomcat - mqu mqu!");
        }
    }
}
