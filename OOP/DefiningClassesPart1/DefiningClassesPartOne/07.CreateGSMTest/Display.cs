using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.CreateGSMTest
{
    public class Display
    {
        private double? size;
        private int? numberOfColors;

        public Display()
        {

        }

        public Display(double? size)
        {
            this.Size = size;
        }

        public Display(double? size, int? numberOfColors)
            : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }

        public double? Size
        {
            get { return size; }
            set { size = value; }
        }

        public int? NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }
    }
}
