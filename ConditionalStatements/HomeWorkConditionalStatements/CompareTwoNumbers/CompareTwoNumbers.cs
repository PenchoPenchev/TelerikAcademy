namespace CompareTwoNumbers
{
    using System;

    class CompareTwoNumbers
    {
        static void Main(string[] args)
        {
            /*Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the                     second one.*/

            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());

            int temp;

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
}
