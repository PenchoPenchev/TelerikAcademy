namespace DescendSortOfNumbers
{
    using System;

    class DescendSortOfNumbers
    {
        static void Main(string[] args)
        {
            /*Sort 3 real values in descending order using nested if statements.*/
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
                    Console.Write("a > ");
                    if (b > c)
                    {
                        Console.Write("b > c");
                    }
                    else
                    {
                        Console.Write("c > b");
                    }
                }
                else
                {
                    Console.Write("c > a > b");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.Write("b > ");
                    if (a > c)
                    {
                        Console.Write("a > c");
                    }
                    else
                    {
                        Console.Write("c > a");
                    }
                }
                else
                {
                    Console.Write("c > b > a");
                }
            }

            Console.WriteLine();
        }
    }
}
