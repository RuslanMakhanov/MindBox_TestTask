using NUnit.Framework;
using ShapeLibrary;
namespace ShapeLibrary.Test
{
    public class Tests
    {
        [Test]
        public void TestCircleArea()
        {
            var circle = new Circle(10);
            Assert.AreEqual(Math.PI * 100, circle.CalculateArea(), 0.0001);
        }
        [Test]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.CalculateArea(), 0.0001);
        }
        [Test]
        public void TestRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [Test]
        public void TestNonRightTriangle()
        {
            var triangle = new Triangle(2, 3, 4);
            Assert.IsFalse(triangle.IsRightTriangle());
        }
    }
}