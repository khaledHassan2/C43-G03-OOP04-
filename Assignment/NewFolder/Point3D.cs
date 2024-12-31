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

                if (double.TryParse(input, out double value))
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Please enter a valid numeric value.");
            }
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
    }
 }
