namespace GreatestCommonDivisor
{
    using System;

    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            /*Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
             * Use the Euclidean algorithm (find it in Internet).*/

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            int aInitialValue = a;

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int bInitialValue = b;

            int changer;

            while (a != 0)
            {
                if (a < b)
                {
                    changer = a;
                    a = b;
                    b = changer;
                }

                a = a % b;

                if (a == 0)
                {
                    Console.WriteLine("NOD({0},{1})={2}", aInitialValue, bInitialValue, b);
                }
            }
        }
    }
}
