using Assignment.NewFolder;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1)Define 3D Point Class and the basic Constructors (use chaining in constructors).

            //Point3D point = new Point3D();
            //Console.WriteLine($"p3{point}");

            //Point3D point2 = new Point3D(1, 2);
            //Console.WriteLine($"p3{point2}");

            //Point3D point3 = new Point3D(1, 2, 3);
            //Console.WriteLine($"p3{point3}"); 
            #endregion
            #region Q2)Override the ToString Function to produce this output:

            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());
            #endregion
            #region Q3) Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).


            //Point3D P1 = Point3D.ReadFromUser("P1");
            //Point3D P2 = Point3D.ReadFromUser("P2");

            //Console.WriteLine($"P1: {P1}");
            //Console.WriteLine($"P2: {P2}");
            #endregion
            #region Q4)Try to use == If(P1 == P2)   Does it work properly? 

            //Point3D P1 = Point3D.ReadFromUser("P1");
            //Point3D P2 = Point3D.ReadFromUser("P2");

            //Console.WriteLine($"P1: {P1}");
            //Console.WriteLine($"P2: {P2}");

            //if (P1 == P2)
            //    Console.WriteLine("P1 and P2 are equal.");
            //else
            //    Console.WriteLine("P1 and P2 are not equal.");
            #endregion
            #region Q5)Define an array of points and sort this array based on X & Y coordinates.

            //     Point3D[] points = new Point3D[]
            //{
            //     new Point3D(5, 2, 1),
            //     new Point3D(3, 4, 7),
            //     new Point3D(5, 1, 3),
            //     new Point3D(1, 6, 9),
            //     new Point3D(3, 4, 2)
            //};

            //     Console.WriteLine("Original Points:");
            //     foreach (var point in points)
            //     {
            //         Console.WriteLine(point);
            //     }

            //     var sortedPoints = points.OrderBy(p => p.X).ThenBy(p => p.Y).ToArray();

            //     Console.WriteLine("\nSorted Points (by X, then by Y):");
            //     foreach (var point in sortedPoints)
            //     {
            //         Console.WriteLine(point);
            //     }
            #endregion
            #region Q6)Implement ICloneable interface to be able to clone the object.To implement more than one interface.class Point3D : IComparable, ICloneable
       //     Point3D[] points = new Point3D[]
       //{
       //     new Point3D(5, 2, 1),
       //     new Point3D(3, 4, 7),
       //     new Point3D(5, 1, 3),
       //     new Point3D(1, 6, 9),
       //     new Point3D(3, 4, 2)
       //};

       //     Console.WriteLine("Original Points:");
       //     foreach (var point in points)
       //     {
       //         Console.WriteLine(point);
       //     }

       //     Array.Sort(points);

       //     Console.WriteLine("\nSorted Points (by X, then by Y, then by Z):");
       //     foreach (var point in points)
       //     {
       //         Console.WriteLine(point);
       //     }

       //     Point3D original = new Point3D(7, 8, 9);
       //     Point3D cloned = (Point3D)original.Clone();

       //     Console.WriteLine("\nOriginal Point:");
       //     Console.WriteLine(original);

       //     Console.WriteLine("\nCloned Point:");
       //     Console.WriteLine(cloned);

       //     Console.WriteLine($"\nAre Original and Cloned the same reference? {ReferenceEquals(original, cloned)}");
            #endregion
        }
    }
}
