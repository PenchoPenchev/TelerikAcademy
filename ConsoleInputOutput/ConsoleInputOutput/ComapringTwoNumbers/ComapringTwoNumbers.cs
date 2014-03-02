namespace ComapringTwoNumbers
{
    using System;

    class ComapringTwoNumbers
    {
        static void Main(string[] args)
        {
            /*Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.*/

            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine(a > b ? "{0} is greater" : "{1} is greater", a, b);

            Console.WriteLine("Second way");
            Console.WriteLine("{0} is greater", Math.Max(a, b));
        }
    }
}
