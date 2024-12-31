using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Assignment.NewFolder
{
    internal class Point3D
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Point3D() : this(0, 0, 0) { }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null)) return true;
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null)) return false;
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            return obj is Point3D other && X == other.X && Y == other.Y && Z == other.Z;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public static Point3D ReadFromUser(string pointName)
        {
            Console.WriteLine($"Enter coordinates for {pointName}:");
            double x = ReadCoordinate("X");
            double y = ReadCoordinate("Y");
            double z = ReadCoordinate("Z");
            return new Point3D(x, y, z);
        }

        private static double ReadCoordinate(string coordinateName)
        {
            while (true)
            {
                Console.Write($"Enter {coordinateName} coordinate: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double value)) return value;
                Console.WriteLine("Invalid input. Please enter a valid numeric value.");
            }
        }
    }
 }
