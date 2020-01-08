using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<double> doubleSet1 = new HashSet<double>();
            ISet<double> doubleSet2 = new HashSet<double>();

            doubleSet1.Add(1.0);
            doubleSet1.Add(4.0);
            doubleSet1.Add(9.0);
            doubleSet1.Add(16.0);

            doubleSet2.Add(1.0);
            doubleSet2.Add(4.0);
            doubleSet2.Add(9.0);
            doubleSet2.Add(16.0);

            if (!(doubleSet1 == doubleSet2)) 
            {
                Console.WriteLine(true);
            }

            ISet<Point> pointSet1 = new HashSet<Point>();
            ISet<Point> pointSet2 = new HashSet<Point>();
            ISet<Point> pointSet3 = new HashSet<Point>();
            Point p1a = new Point(1.0, 1.0, 1.0);
            Point p1b = new Point(4.0, 4.0, 4.0);
            Point p1c = new Point(9.0, 9.0, 9.0);
            Point p1d = new Point(16.0, 16.0, 16.0);

            pointSet1.Add(p1a);
            pointSet1.Add(p1b);
            pointSet1.Add(p1c);
            pointSet1.Add(p1d);

            Point p2a = new Point(1.0, 1.0, 1.0);
            Point p21b = new Point(1.0, 1.0, 1.0);
            Point p2c = new Point(9.0, 9.0, 9.0);
            Point p2d = new Point(16.0, 16.0, 16.0);

            pointSet2.Add(p2a);
            pointSet2.Add(p2a);
            pointSet2.Add(p21b);
            pointSet2.Add(p2c);
            pointSet2.Add(p2d);

            foreach(Point point in pointSet2)
            {
                Console.WriteLine($"{point.X},{point.Y},{point.Z}");
            }

            if (!(pointSet1 == pointSet2))
            {
                Console.WriteLine(true);
            }

            pointSet3 = pointSet1;

            if ((pointSet1 == pointSet3))
            {
                Console.WriteLine($"pointSet1 == pointSet3? :{pointSet1 == pointSet3}");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
