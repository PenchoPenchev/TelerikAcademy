using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you?: ");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("After ten years you will be {0} years old", age + 10);
        }
    }
}
