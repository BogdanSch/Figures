using System;
using System.Collections.Generic;
using System.Text;

namespace Geometrical_Figures
{
    class Rectangle : Shape
    {
        public Rectangle(double a, double b)
        {
            Width = a;
            Height = b;
        }

        public double Width
        {
            get
            {
                return Width;
            }
            set
            {
                if (value > 0)
                    Width = value;
            }
        }
        public double Height
        {
            get
            {
                return Height;
            }
            set
            {
                if (value > 0)
                    Height = value;
            }
        }
        public override string GetInfo()
        {
            return $"Rectangle with sides {Width}, {Height} \n P = {P()} \n S = {S()}";
        }

        public override double P()
        {
            return 2 * Height + 2 * Width;
        }

        public override double S()
        {
            return Width * Height;
        }
    }
}
