namespace PrintMinMaxNumbers
{
    using System;
    class PrintMinMaxNumbers
    {
        static void Main(string[] args)
        {
            /*Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.*/

            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());

            Random randomGenerator = new Random();
            int min = 0;
            int max = 0;

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomGenerator.Next(1, 100);
                if (min == 0)
                {
                    min = arr[i];
                }
                min = Math.Min(min, arr[i]);
                max = Math.Max(max, arr[i]);

                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("The smallest number {0}, the biggest number {1}", min, max);
        }
    }
}
