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
        Line line1;
        Line line2;
        public Rectangle(Point point1, Point point2, Point point3, Point point4)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
            line1 = new Line(Point1, Point2);
            line2 = new Line(Point2, Point3);
        }
        public double Perimetr()
        {
            return 2 * (line1.Lenght() + line2.Lenght());
        }

        public double Square()
        {
            return line1.Lenght() * line2.Lenght();
        }
    }
}
