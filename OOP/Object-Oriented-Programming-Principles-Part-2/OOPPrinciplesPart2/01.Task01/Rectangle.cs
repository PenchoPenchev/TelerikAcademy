namespace _01.Task01
{
    using System;
    
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) 
            : base(width, height)
        {
            
        }

        public override void CalculateSurface()
        {
            double surface = this.Width * this.Height;
            Console.WriteLine("Rectangle surface with width = {0} and height = {1} is {2}", this.Width, this.Height, surface);
        }
    }
}
