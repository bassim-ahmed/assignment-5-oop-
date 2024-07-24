using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.part_1
{
    public class Point3D : IComparable<Point3D>, ICloneable
    {


        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        public static Point3D FromInput()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter x coordinate: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Enter y coordinate: ");
                    int y = int.Parse(Console.ReadLine());
                    Console.Write("Enter z coordinate: ");
                    int z = int.Parse(Console.ReadLine());
                    return new Point3D(x, y, z);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter integer values.");
                }
            }

        }
        public int CompareTo(Point3D other)
        {
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
