namespace NotDivisibleByThreeAndSeven
{
    using System;
    class NotDivisibleByThreeAndSeven
    {
        static void Main(string[] args)
        {
            /*Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.*/
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 21 == 0)
                {
                    Console.WriteLine(i);    
                }
            }
        }
    }
}
