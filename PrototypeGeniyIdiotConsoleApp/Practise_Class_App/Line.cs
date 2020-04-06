using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_Class_App
{
    class Line
    {
        public Point Point1;
        public Point Point2;

        public Line(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public double Lenght()
        {
            double dX = Math.Abs(Point2.X - Point1.X);
            double dY = Math.Abs(Point2.Y - Point1.Y);
            return Math.Sqrt(Math.Pow(dX,2) + Math.Pow(dY,2));
        }

        public string Print()
        {
            return "(" + Point1.Print() + "," + Point2.Print() + ")";
        }
    }
}
