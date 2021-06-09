using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatororEveruthing
{
    class SquareEquation
    {

        private double a;
        private double b;
        private double c;
        private double d;
        private double x1;
        private double x2;

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public SquareEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void CalculateDiscriminant()
        {
            Console.WriteLine(d = b * b - 4 * a * c);
        }

        public void TwoRoots()
        {
            Console.WriteLine(x1 = (-b + Math.Sqrt(d)) / (2 * a));
            Console.WriteLine(x2 = -(-b - Math.Sqrt(d)) / (2 * a));
        }

        public void OneRoot()
        {
            Console.WriteLine(x1 = -(b / 2 * a));
        }

        public void NoSolution()
        {
            Console.WriteLine("The discriminant is less than 0! There are no real roots");
        }

        public void Roots()
        {
            CalculateDiscriminant();

            if (d > 0)
            {
                TwoRoots();
            }
            else if (d == 0)
            {
                OneRoot();
            }
            else if (d < 0)
            {
                NoSolution();
            }
        }

        public override string ToString()
        {
            return $"a: {a} b: {b} c: {c} d: {d} x1: {x1} x2: {x2}";
        }

    }
}