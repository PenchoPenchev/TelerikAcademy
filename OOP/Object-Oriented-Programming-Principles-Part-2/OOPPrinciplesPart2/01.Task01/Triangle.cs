using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Task01
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) 
            : base(width, height)
        {
            
        }

        public override void CalculateSurface()
        {
            double surface = this.Width * this.Height / 2;
            Console.WriteLine("Triangle surface with width = {0} and height = {1} is {2}", this.Width, this.Height, surface);
        }
    }
}
