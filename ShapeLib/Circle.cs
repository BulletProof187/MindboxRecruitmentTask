using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ShapeLib
{
    public class Circle : IShape
    {
        public string Name { get; set ; }
        public double Area { get { return GetArea(); } }
        public double Perimeter { get { return GetPerimeter(); } }
        public double Radius { get; set; }
        public double GetArea()
        {
            return PI * Pow(Radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * PI * Radius;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
