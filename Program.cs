using System;
using System.Collections.Generic;

namespace Geometrical_Figures
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            List<Shape> shapes = CreateShapes(n);
            Print(shapes);
        }

        private static void Print(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.GetInfo());
            }
        }

        private static List<Shape> CreateShapes(int n)
        {
            List<Shape> ls = new List<Shape>();

            for (int i = 0; i < n; i++)
            {
                ls.Add(new Triangle(rnd.Next(1, 20), rnd.Next(1, 20), rnd.Next(1, 20)));
                ls.Add(new Rectangle(rnd.Next(1, 20), rnd.Next(1, 20)));
                ls.Add(new Circle(rnd.Next(1, 20)));
            }

            return ls;
        }
    }
}
