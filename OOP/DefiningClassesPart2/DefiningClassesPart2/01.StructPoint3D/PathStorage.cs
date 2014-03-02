/*4. Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and 
 * load paths from a text file. Use a file format of your choice.*/

namespace _01.StructPoint3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class PathStorage
    {
        public static List<Path> paths = new List<Path>();

        public static void LoadPathsFromFile(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);

            using (reader)
            {
                string line = string.Empty;
                int pointCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] point3D = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                    paths.Add(new Path());

                    for (int i = 0; i < point3D.Length; i++)
                    {
                        string[] pointCoordinates = point3D[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        paths[pointCount].AddPoint(new Point3D(int.Parse(pointCoordinates[0]),
                            int.Parse(pointCoordinates[1]), int.Parse(pointCoordinates[2])));
                    }

                    pointCount++;
                }
            }
        }

        public static void SaveInFile(string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath);

            using (writer)
            {
                foreach (Path path in paths)
                {
                    for (int i = 0; i < path.GetPoints.Length - 1; i++)
                    {
                        Point3D point = path.GetPoints[i];
                        writer.Write(point.X + "," + point.Y + "," + point.Z + ";");
                    }
                    Point3D lastPoint = path.GetPoints[path.GetPoints.Length - 1];
                    writer.Write(lastPoint.X + "," + lastPoint.Y + "," + lastPoint.Z + Environment.NewLine);
                }
            }
        }

        public static void PrintPaths()
        {
            if (paths.Count == 0)
            {
                Console.WriteLine("Empty list of paths.");
            }
            else
            {
                for (int i = 0; i < paths.Count; i++)
                {
                    Console.WriteLine("Points of path #{0}: ", (i + 1));
                    for (int j = 0; j < paths[i].GetPoints.Length; j++)
                    {
                        Console.WriteLine("Coordinates of point #{0}: {1}", (j + 1), paths[i].GetPoints[j]);
                    }
                    Console.WriteLine(new string('-', 25));
                }
            }
        }
    }
}
