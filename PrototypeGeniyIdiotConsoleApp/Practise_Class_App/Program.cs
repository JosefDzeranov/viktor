using System;

namespace Practise_Class_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(2, 3);
            Console.WriteLine(point.Print());

            Point point1 = new Point(4, 1);
            Point point2 = new Point(1, 1);
            Point point3 = new Point(2, 2);
            Line line1 = new Line(point1, point2);
            Line line2 = new Line(point2, point3);
            Line line3 = new Line(point3, point1);
            Triangle triangle = new Triangle(point1, point1, point3);
            Console.WriteLine(line1.Lenght());
            Console.WriteLine(line1.Print());
            Console.WriteLine(triangle.Perimetr(line1, line2, line3));
        }
    }
}
