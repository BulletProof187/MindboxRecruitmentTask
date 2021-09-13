using System;

namespace ShapeLib
{
    public interface IShape
    {
        public string Name { get; set; }
        public double Area { get {return GetArea(); } }
        public double Perimeter { get { return GetPerimeter(); } }
        public double GetArea();
        public double GetPerimeter();
    }
}
