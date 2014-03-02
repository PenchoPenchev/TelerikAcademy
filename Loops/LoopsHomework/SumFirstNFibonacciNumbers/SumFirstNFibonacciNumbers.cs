namespace SumFirstNFibonacciNumbers
{
    using System;

    class SumFirstNFibonacciNumbers
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1,                2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …*/

            int firstNumber = 0;
            int secondNumber = 1;
            int thridNumber = firstNumber + secondNumber;
            int sumFibonacciNumbers = 0;

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}", firstNumber);

                sumFibonacciNumbers += firstNumber;
                firstNumber = secondNumber;
                secondNumber = thridNumber;
                thridNumber = firstNumber + secondNumber;

                if (i + 1 == n)
                {
                    Console.Write(" = {0}", sumFibonacciNumbers);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" + ");
                }
            }
        }
    }
}
