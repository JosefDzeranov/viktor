﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_Class_App
{
    class Triangle
    {
        public Point Point1;
        public Point Point2;
        public Point Point3;
        public Line Line1;
        public Line Line2;
        public Line Line3;

        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }

        public double Perimetr()
        {
           return Line1.Lenght() + Line2.Lenght() + Line3.Lenght();
        }

        public string Print()
        {
            return "(" + Point1.Print() + "," + Point2.Print() + "," + Point3.Print() + ")";
        }

    }
}
