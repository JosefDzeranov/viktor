using System;

namespace Practise_Class_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(2, 3);
            Console.WriteLine(point.Print());

            Point point1 = new Point(1, 1);
            Point point2 = new Point(2, 1);
            Point point3 = new Point(2, 3);
            Point point4 = new Point(1, 1);

            Line line1 = new Line(point1, point2);
            Line line2 = new Line(point2, point3);
            Line line3 = new Line(point3, point1);

            Triangle triangle = new Triangle(point1, point1, point3);
            triangle.Line1 = line1;
            triangle.Line2 = line2;
            triangle.Line3 = line3;

            Rectangle rectangle = new Rectangle(point1, point1, point3, point4);
            Line line4 = new Line(point3, point4);
            Line line5 = new Line(point4, point1);
            rectangle.Line1 = line1;
            rectangle.Line2 = line2;
            rectangle.Line3 = line4;
            rectangle.Line4 = line5;

            Console.WriteLine(line1.Lenght());
            Console.WriteLine(line1.Print());
            Console.WriteLine(triangle.Perimetr());
            Console.WriteLine(rectangle.Perimetr());
            Console.WriteLine(rectangle.Square());
        }
    }
}
