using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_Class_App
{
    class Triangle
    {
        public Point Point1;
        public Point Point2;
        public Point Point3;

        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }

        public double Perimetr()
        {
            Line line1 = new Line(Point1, Point2);
            Line line2 = new Line(Point2, Point3);
            Line line3 = new Line(Point3, Point1);
            return line1.Lenght() + line2.Lenght() + line3.Lenght();
        }

        public string Print()
        {
            return "(" + Point1.Print() + "," + Point2.Print() + "," + Point3.Print() + ")";
        }

    }
}
