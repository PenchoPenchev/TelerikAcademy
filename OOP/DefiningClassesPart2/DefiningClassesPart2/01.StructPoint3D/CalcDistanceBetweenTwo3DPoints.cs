/*3. Write a static class with a static method to calculate the distance between two points in the 3D space.*/

namespace _01.StructPoint3D
{
    using System;
    
    public static class CalcDistanceBetweenTwo3DPoints
    {
        public static void CalcDistance(Point3D firstPoint, Point3D secondPoint)
        {
            //d(p,q) = SQRT[(p1-q1)^2 + p2-q2)^2 + p3-q3)^2]
            double distance = 0;

            double firstSquare = Math.Pow(firstPoint.X - secondPoint.X, 2);
            double secondSquare = Math.Pow(firstPoint.Y - secondPoint.Y, 2);
            double thirdSquare = Math.Pow(firstPoint.Z - secondPoint.Z, 2);

            distance = Math.Sqrt(firstSquare + secondSquare + thirdSquare);

            Console.WriteLine("The distance between {0} and {1} = {2}",firstPoint.ToString(), secondPoint.ToString(), distance);
        }

    }
}
