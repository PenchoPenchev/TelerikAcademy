/*1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
 * Implement the ToString() to enable printing a 3D point.*/

/*2. Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
 * Add a static property to return the point O.*/

namespace _01.StructPoint3D
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D zeroPoint = new Point3D(0, 0, 0);
        
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        
        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D ZeroPoint { get; set; }

        public override string ToString()
        {
            string result = string.Format("3D point coords: x={0},y={1},z={2}", X, Y, Z);
            return result;
        }
    }
}
