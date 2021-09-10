using System;

namespace Course
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C { get; private set; }
        public double Area;

        public double CalcularArea()
        {
            double p = (A + B + C) / 2;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
    }

}
