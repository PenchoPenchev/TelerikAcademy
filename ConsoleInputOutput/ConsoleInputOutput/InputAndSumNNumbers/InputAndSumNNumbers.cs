namespace InputAndSumNNumbers
{
    using System;

    class InputAndSumNNumbers
    {
        static void Main(string[] args)
        {
            /*Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. */

            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());

            int sum = 0;

            while (n > 0)
            {
                Console.Write("number = ");
                sum += Int32.Parse(Console.ReadLine());   
                n--;
            }

            Console.WriteLine("The sum is {0}",sum);
        }
    }
}
