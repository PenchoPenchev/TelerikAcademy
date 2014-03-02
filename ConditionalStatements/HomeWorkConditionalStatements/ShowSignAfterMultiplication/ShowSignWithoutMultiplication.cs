namespace ShowSignWithoutMultiplication
{
    using System;

    class ShowSignWithoutMultiplication
    {
        static void Main(string[] args)
        {
            /*Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if                statements.*/

            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = Int32.Parse(Console.ReadLine());

            int minus = 0;

            if (a < 0)
            {
                minus++;
            }
            if (b < 0)
            {
                minus++;
            }
            if (c < 0)
            {
                minus++;
            }

            Console.WriteLine(minus == 0 || minus % 2 == 0 ? "The sign will be +" : "The sign will be -");
        }
    }
}
