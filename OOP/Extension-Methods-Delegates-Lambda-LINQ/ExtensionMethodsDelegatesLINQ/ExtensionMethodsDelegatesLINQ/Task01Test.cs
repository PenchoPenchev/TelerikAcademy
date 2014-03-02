/*1. Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
 * and has the same functionality as Substring in the class String.*/

namespace TasksFrom1to7
{
    using System;
    using System.Text;
    
    public static class Task01Test
    {
        public static void Test()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Substring extension method for StringBuilder");

            string test = sb.Substring(0, 9);
            Console.WriteLine(test);
        }
    }
}
