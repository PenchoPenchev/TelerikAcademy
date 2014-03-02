/*4. Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save 
 * and load paths from a text file. Use a file format of your choice.*/

namespace _01.StructPoint3D
{
    using System;
    using System.Collections.Generic;
    
    public class Path
    {
        private List<Point3D> points;

        public Point3D[] GetPoints
        {
            get
            {
                return this.points.ToArray();
            }
        }

        #region constructors
        public Path()
            : this(new List<Point3D>())
        {

        }

        public Path(IEnumerable<Point3D> points)
        {
            this.points = new List<Point3D>(points);
        }
        #endregion


        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }
    }
}
