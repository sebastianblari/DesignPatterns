using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Point
    {
        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void SetToOrigin()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public void Print()
        {
            Console.WriteLine($"X: {X}");
            Console.WriteLine($"Y: {Y}");
            Console.WriteLine($"Z: {Z}");
        }
        public double X;
        public double Y;
        public double Z;
    }
}
