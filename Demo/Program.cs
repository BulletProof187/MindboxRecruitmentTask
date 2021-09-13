using System;
using ShapeLib;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle a = new Circle(11);
            Triangle b = new Triangle(5, 3, 7);
            Triangle c = new Triangle(5, 3, true, 0.35);

            Console.WriteLine("Circle area is:");
            Console.WriteLine(a.Area);
            Console.WriteLine();
            Console.WriteLine("Triangle b area is:");
            Console.WriteLine(b.Area);
            Console.WriteLine();
            Console.WriteLine("Triangle c area is:");
            Console.WriteLine(c.Area);
            Console.WriteLine();
            Console.WriteLine("Triangle c sides are:");
            Console.WriteLine(c.Side0);
            Console.WriteLine(c.Side1);
            Console.WriteLine(c.Side2);
            Console.ReadLine();
        }
    }
}
