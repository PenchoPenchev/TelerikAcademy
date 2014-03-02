namespace IntervalNumbersDivisionByFive
{
    using System;

    class IntervalNumbersDivisionByFive
    {
        static void Main(string[] args)
        {
            /*Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the                        reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.*/
            
            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("p({0},{1}) = {2}", a, b, counter);
        }
    }
}
