using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_13
{
    internal class Shape
    {
        public virtual double Area()
        {
            return 0;
        }
    }
    internal class ShapeСircle:Shape
    {
        internal string Name { get; set; } = "Сircle";
        int Radius { get; set; } = 0;
        internal ShapeСircle(int radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }
    }
    internal class ShapeSquare : Shape
    {
        internal string Name { get; set; } = "Square";
        int Side { get; set; } = 0;
        internal ShapeSquare(int side)
        {
            Side = side;
        }

        public override double Area()
        {
            double area = Side * Side;
            return area;
        }
    }
    internal class ShapeTriangle : Shape
    {
        internal string Name { get; set; } = "Triangle";
        int Side { get; set; } = 0;
        int Height { get; set; } = 0;
        internal ShapeTriangle(int side, int height)
        {
            Side = side;
            Height = height;
        }

        public override double Area()
        {
            double area = Side * Height/2;
            return area;
        }
    }
}
