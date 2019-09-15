using System;

namespace Geometry
{
    public class Triangle : IAreaable
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentException(nameof(a));
            if (b <= 0)
                throw new ArgumentException(nameof(b));
            if (c <= 0)
                throw new ArgumentException(nameof(c));

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("It is not Triangle");


            A = a;
            B = b;
            C = c;
        }

        public double CalcArea()
        {
            double P = (A + B + C) / 2.0;
            return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }

        public bool IsRightTriangle()
        {
            if (A > B && A > C)
                return A * A == B * B + C * C;

            if (B > A && B > C)
                return B * B == A * A + C * C;

            return C * C == A * A + B * B;
        }

    }
}
