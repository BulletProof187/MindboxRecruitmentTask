using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLib;

namespace UnitTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleArea()
        {
            double radius = 7.43;
            double expected = 173.4313;

            Circle circle = new Circle(radius);

            Assert.AreEqual(expected, circle.Area, 0.001);
        }
        
        [TestMethod]
        public void CirclePerimeter()
        {
            double radius = 5.97;
            double expected = 37.51062;

            Circle circle = new Circle(radius);

            Assert.AreEqual(expected, circle.Perimeter, 0.001);
        }
    }

    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleArea()
        {
            double side0 = 3;
            double side1 = 4;
            double side2 = 5;

            double expected = 6;

            Triangle triangle = new Triangle(side0, side1, side2);

            Assert.AreEqual(expected, triangle.Area);
        }

        [TestMethod]
        public void TrianglePerimeter()
        {
            double side0 = 4.7;
            double side1 = 5.21;
            double side2 = 8;

            double expected = 17.91;

            Triangle triangle = new Triangle(side0, side1, side2);

            Assert.AreEqual(expected, triangle.Perimeter);
        }


        [TestMethod]
        public void TriangleCtorByTwoSidesAndAngle()
        {
            double side0 = 5;
            double side1 = 8;
            double angle = 0.35;

            double expectedSide2 = 3.722;

            Triangle triangle = new Triangle(side0, side1, true, angle);

            Assert.AreEqual(expectedSide2, triangle.Side2, 0.001);
        }

        [TestMethod]
        public void TriangleRightCheck()
        {
            double side0 = 3;
            double side1 = 4;
            double side2 = 5;


            Triangle triangle = new Triangle(side0, side1, side2);

            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void TriangleNotRightCheck()
        {
            double side0 = 30;
            double side1 = 18;
            double side2 = 20;


            Triangle triangle = new Triangle(side0, side1, side2);

            Assert.IsFalse(triangle.IsRightTriangle());
        }
    }
}
