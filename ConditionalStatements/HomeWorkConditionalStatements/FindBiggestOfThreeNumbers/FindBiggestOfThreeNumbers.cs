namespace FindBiggestOfThreeNumbers
{
    using System;

    class FindBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the biggest of three integers using nested if statements.*/
            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = Int32.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a > b and a > c");
                }
                else
                {
                    Console.WriteLine("c > a and c > b");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b > a and b > c");
                }
                else
                {
                    Console.WriteLine("c > b and c > a");
                }
            }
        }
    }
}
