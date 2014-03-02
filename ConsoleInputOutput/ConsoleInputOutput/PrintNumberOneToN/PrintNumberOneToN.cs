namespace PrintNumberOneToN
{
    using System;

    class PrintNumberOneToN
    {
        static void Main(string[] args)
        {
            /*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a                  single line.*/

            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
