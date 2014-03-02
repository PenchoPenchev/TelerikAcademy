namespace PrintMatrix
{
    using System;

    class PrintMatrix
    {
        static void Main(string[] args)
        {
            /*Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix*/

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col < n + row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
