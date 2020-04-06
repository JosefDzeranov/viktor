using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_Class_App
{
    class Rectangle
    {
        public Point Point1;
        public Point Point2;
        public Point Point3;
        public Point Point4;
        public Line Line1;
        public Line Line2;
        public Line Line3;
        public Line Line4;

        public Rectangle(Point point1, Point point2, Point point3, Point point4)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
        }
        public double Perimetr()
        {
            return 2 * (Line1.Lenght() + Line2.Lenght());
        }

        public double Square()
        {
            return Line1.Lenght() * Line2.Lenght();
        }
    }
}
