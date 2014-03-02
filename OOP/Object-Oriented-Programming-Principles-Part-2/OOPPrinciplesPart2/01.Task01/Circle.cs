namespace _01.Task01
{
    using System;

    public class Circle : Shape
    {
        public Circle(double radius) 
            : base(radius)
        {
            
        }

        public override void CalculateSurface()
        {
            double surface = Math.PI * Math.Pow(this.Width, 2);

            Console.WriteLine("Circle surface with radius = {0} is {1}", this.Width, surface);
        }
    }
}
