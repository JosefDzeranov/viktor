using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_Class_App
{
    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public string Print()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}
