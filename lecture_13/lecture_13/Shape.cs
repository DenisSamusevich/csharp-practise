using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_13
{
    internal class Shape
    {
        public virtual double Square()
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

        public override double Square()
        {
            double square = Math.PI * Radius * Radius;
            return square;
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

        public override double Square()
        {
            double square = Math.PI * Side * Side;
            return square;
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

        public override double Square()
        {
            double square = Math.PI * Side * Side;
            return square;
        }
    }
}
