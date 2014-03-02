using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.AbstractClassesAndInterfaces
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, Sex gender)
            : base(name, age, Sex.Female)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("Baby kitten - mqu mqu!");
        }
    }
}
