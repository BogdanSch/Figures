using System;
using System.Collections.Generic;
using System.Text;

namespace Geometrical_Figures
{
    class Circle : Shape
    {
        public Circle(double r)
        {
            R = r;
        }
        public double R { get; set; }
        public override string GetInfo()
        {
            return $"Circle with radius {R} \n C = {P()} \n S = {S()}";
        }

        public override double P()
        {
            return 2 * Math.PI * R;
        }

        public override double S()
        {
            return Math.PI * (R * R);
        }
    }
}
