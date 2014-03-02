namespace _01.Task01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public abstract class Shape
    {
        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Shape(double width)
        {
            if (width <= 0)
            {
                throw new IndexOutOfRangeException("Width should be greater than zero.");
            }

            this.Width = width;
        }

        public Shape(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new IndexOutOfRangeException("Width and height should be greater than zero.");
            }
            
            this.Width = width;
            this.Height = height;
        }

        public abstract void CalculateSurface();
        
    }
}
