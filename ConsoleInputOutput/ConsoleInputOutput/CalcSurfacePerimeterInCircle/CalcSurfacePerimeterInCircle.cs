namespace CalcSurfacePerimeterInCircle
{
    using System;

    class CalcSurfacePerimeterInCircle
    {
        static void Main(string[] args)
        {
            /*Write a program that reads the radius r of a circle and prints its perimeter and area.*/

            Console.Write("r = ");
            int r = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The perimeter of the circle is {0}", 2 * Math.PI * r);
            Console.WriteLine("The surface of the circle is {0}", Math.PI * Math.Pow(r, 2));
        }
    }
}
