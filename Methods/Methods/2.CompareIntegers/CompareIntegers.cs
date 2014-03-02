namespace _2.CompareIntegers
{
    using System;

    class CompareIntegers
    {
        /*Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program
         * that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/
        public static int GetMax(int a, int b)
        {
            int bigger = a;

            if (b > a)
            {
                bigger = b;
            }

            return bigger;
        }

        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            int max = GetMax(a, b);
            max = GetMax(max, c);

            Console.WriteLine("The greatest number is {0}", max);
        }
    }
}
