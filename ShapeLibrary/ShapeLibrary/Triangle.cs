using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            if (!IsValidTriangle())
                throw new ArgumentException("Некорректные длины сторон для треугольника.");
        }

        public double CalculateArea()
        {
            // Используем формулу для расчета площади треугольника
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public bool IsRightTriangle()
        {
            // Проверка на прямоугольный треугольник
            var sides = new[] { A, B, C };
            Array.Sort(sides); // Сортируем для упрощения проверки
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 0.0001;
        }

        private bool IsValidTriangle()
        {
            return A + B > C && A + C > B && B + C > A;
        }
    }

}
