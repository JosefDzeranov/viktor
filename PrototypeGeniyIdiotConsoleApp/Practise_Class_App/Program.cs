using System;

namespace Practise_Class_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(2, 3);
            //Console.WriteLine(point.Print());

            Point point1 = new Point(1, 1);
            Point point2 = new Point(2, 1);
            Point point3 = new Point(2, 3);
            Point point4 = new Point(1, 1);

            Line line1 = new Line(point1, point2);

            Triangle triangle = new Triangle(point1, point1, point3);

            Rectangle rectangle = new Rectangle(point1, point1, point3, point4);
  
            Console.WriteLine(line1.Lenght());
            Console.WriteLine(line1.Print());
            Console.WriteLine(triangle.Perimetr());
            Console.WriteLine(rectangle.Perimetr());
            Console.WriteLine(rectangle.Square());
            
            Fraction fraction1 = new Fraction(2, 5);
            Fraction fraction2 = new Fraction(1, 5);
            Console.WriteLine(fraction1.Summation(fraction2).ConvertToDouble().ToString());
            Console.WriteLine(fraction1.Deduction(fraction2).ConvertToDouble().ToString());
            Console.WriteLine(fraction1.Separation(fraction2).Print());
            Console.WriteLine(fraction1.Multiplication(fraction2).Print());
        }
    }
}
