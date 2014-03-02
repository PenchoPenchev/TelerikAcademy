/*1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
 * Implement the ToString() to enable printing a 3D point.*/

/*2. Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
 * Add a static property to return the point O.*/

/*3. Write a static class with a static method to calculate the distance between two points in the 3D space.*/

/*4. Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and 
 * load paths from a text file. Use a file format of your choice.*/

/*5. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
 * Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
 * Implement methods for adding element, accessing element by index, removing element by index, 
 * inserting element at given position, clearing the list, finding element by its value and ToString(). 
 * Check all input parameters to avoid accessing elements at invalid positions.*/

/*6. Implement auto-grow functionality: when the internal array is full, 
 * create a new array of double size and move all elements to it.*/

/*7. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
 * You may need to add a generic constraints for the type T.*/

/* ============================================================================
 * Повечето условия са си по класовете, защото тук става прекалено натруфено.
 * ============================================================================*/

namespace _01.StructPoint3D
{
    using System;

    [Version("1.00")]
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine(Point3D.ZeroPoint);
            
            Point3D firstPoint = new Point3D(1, 2, 3);
            Point3D secondPoint = new Point3D(3, 4, 5);

            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);

            CalcDistanceBetweenTwo3DPoints.CalcDistance(firstPoint, secondPoint);

            Path path = new Path();

            path.AddPoint(firstPoint);
            path.AddPoint(secondPoint);

            PathStorage.paths.Add(path);

            PathStorage.SaveInFile(@"..\..\Files\3DPoints.txt");

            PathStorage.PrintPaths();

            PathStorage.LoadPathsFromFile(@"..\..\Files\3DPoints.txt");

            //11.
            Type type = typeof(MainClass);

            var allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("Attributed class is version {0}.", attr.Version);
            }
        }
    }
}
