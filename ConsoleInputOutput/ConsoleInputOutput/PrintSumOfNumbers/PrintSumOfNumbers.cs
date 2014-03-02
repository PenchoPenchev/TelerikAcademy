namespace PrintSumOfNumbers
{
    using System;

    class PrintSumOfNumbers
    {
        static void Main(string[] args)
        {
            /*Write a program that reads 3 integer numbers from the console and prints their sum.*/

            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
        }
    }
}
