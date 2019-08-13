using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shipes = new Shape[3];
            shipes[0] = new ShapeСircle(4);
            shipes[1] = new ShapeSquare(5);
            shipes[2] = new ShapeTriangle(6,8);
            Console.WriteLine("This is {0}.CLR Type is {1}.Square is {2}", (ShapeСircle)shipes[0], );

        }
    }
}
