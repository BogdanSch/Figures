using System;
using System.Collections.Generic;
using System.Text;

namespace Geometrical_Figures
{
    class Triangle : Shape
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A
        {
            get
            {
                return A;
            }
            set
            {
                if (value < 0)
                    return;
                A = value;
            }
        }
        public double B
        {
            get
            {
                return B;
            }
            set
            {
                if (value < 0)
                    return;
                B = value;
            }
        }
        public double C
        {
            get
            {
                return C;
            }
            set
            {
                if (value > 0)
                    return;
                C = value;
            }
        }
        public override string GetInfo()
        {
            return $"Triangle with sides {A}, {B},{C} \n P = {P()} \n S = {S()}";
        }

        public override double P()
        {
            return A + B + C;
        }

        public override double S()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
