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
            Shape [] shipes = new Shape[3];
            shipes[0] = new ShapeСircle(4);
            shipes[1] = new ShapeSquare(5);
            shipes[2] = new ShapeTriangle(6,8);
            for (int i = 0; i < shipes.Length; i++)
			{
                switch (shipes[i])
                {
                    case ShapeСircle shapeCircle:
                        {
                            
                            Console.WriteLine("This is {0}. CLR Type is {1}. Square is {2}",shapeCircle.Name, shapeCircle.GetType().Name, Math.Round(shapeCircle.Area(),2));
                            break;
                        }
                    case ShapeSquare shapeSquare:
                        {
                            Console.WriteLine("This is {0}. CLR Type is {1}. Square is {2}", shapeSquare.Name, shapeSquare.GetType().Name, Math.Round(shapeSquare.Area(),2));
                            break;
                        }
                    case ShapeTriangle shapeTriangle:
                        {
                            Console.WriteLine("This is {0}. CLR Type is {1}. Square is {2}", shapeTriangle.Name, shapeTriangle.GetType().Name,Math.Round(shapeTriangle.Area(),2));
                            break;
                        }
		            default:
                        {
                            break;
                        }
	            }
                
			}
            Console.Read();
        }
    }
}
