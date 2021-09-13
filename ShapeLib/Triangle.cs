using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ShapeLib
{
    public class Triangle : IShape
    {
        public string Name { get ; set ; }
        public double Side0 { get ; set ; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Area { get { return GetArea(); } }
        public double Perimeter { get { return GetPerimeter(); } }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("All sides of a triangle should be positive");
            
            if ((firstSide >= secondSide + thirdSide)||
                (secondSide >= firstSide + thirdSide)||
                (thirdSide >= firstSide + secondSide))
                throw new ArgumentException("A side cannot exceed a sum of other sides of a triangle");

            Side0 = firstSide;
            Side1 = secondSide;
            Side2 = thirdSide;
        }
        public Triangle(double firstSide, double secondSide, bool byAngle, double angleBetweenThemInRadians) //bool is there to make the ctor overload possible
        {
            Side0 = firstSide;
            Side1 = secondSide;

            //using the law of cosines to determine the Side2 which is
            //a2 = b2 + c2 − 2bc cosA => Side2 = Sqrt(b2 + c2 − 2bc*cosA)
            Side2 = Sqrt(Pow(firstSide,2) + Pow(secondSide, 2) - 2 * firstSide * secondSide * Cos(angleBetweenThemInRadians));
        }
        public double GetArea() //using Heron's formula
        {
            double semiPerimeter = (Side0 + Side1 + Side2) / 2;
            return Sqrt(semiPerimeter * (semiPerimeter - Side0) * (semiPerimeter - Side1) * (semiPerimeter - Side2));
        }
        public double GetPerimeter()
        {
            return Side0 + Side1 + Side2;
        }
        public bool IsRightTriangle() //using pythagorean theorem
        {
            if ((Sqrt(Pow(Side0, 2) + Pow(Side1, 2)) == Side2) ||
                (Sqrt(Pow(Side1, 2) + Pow(Side2, 2)) == Side0) ||
                (Sqrt(Pow(Side2, 2) + Pow(Side0, 2)) == Side1))
                return true;
            else return false;
        }

    }
}
