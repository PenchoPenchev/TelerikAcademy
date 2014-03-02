namespace PrintNumbersToN
{
    using System;

    class PrintNumbersToN
    {
        static void Main(string[] args)
        {
            /*Write a program that prints all the numbers from 1 to N.*/
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
