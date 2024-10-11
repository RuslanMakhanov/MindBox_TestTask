using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5);
            var triangle = new Triangle(3, 4, 5);

            double circleArea = ShapeCalculator.GetArea(circle);
            double triangleArea = ShapeCalculator.GetArea(triangle);

            Console.WriteLine($"Circle Area: {circleArea}");
            Console.WriteLine($"Triangle Area: {triangleArea}");
            Console.ReadKey();
        }
    }
}
