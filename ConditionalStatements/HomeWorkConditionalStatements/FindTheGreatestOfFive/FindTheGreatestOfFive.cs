namespace FindTheGreatestOfFive
{
    using System;
    class FindTheGreatestOfFive
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the greatest of given 5 variables.*/

            int theGreatest = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("numer{0} = ", i+1);
                theGreatest = Math.Max(theGreatest, Int32.Parse(Console.ReadLine()));
            }
            Console.WriteLine("The greatest number is {0}", theGreatest);
        }
    }
}
