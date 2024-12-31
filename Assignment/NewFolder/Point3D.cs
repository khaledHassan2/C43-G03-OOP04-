using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Assignment.NewFolder
{
    public class Point3D : IComparable<Point3D>, ICloneable
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

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(Point3D other)
        {
            if (other == null) return 1;

            if (X != other.X)
                return X.CompareTo(other.X);

            if (Y != other.Y)
                return Y.CompareTo(other.Y);

            return Z.CompareTo(other.Z);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}
