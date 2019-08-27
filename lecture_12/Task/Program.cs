using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {   
            StructRestangle[] structRestangle = new StructRestangle[100];

            Random random = new Random();

            for (int i = 0; i < structRestangle.Length; i++)
            {
                StructRestangle structRestangleOne = new StructRestangle(random.Next(1, 10));
                structRestangle[i] = structRestangleOne;
            }
            for (int i = 1; i < structRestangle.Length; i++)
            {
                if (structRestangle[i].Equals(structRestangle[1]))
                {
                    Console.WriteLine("{0} квадрат повторяется с первым квадратом",i);
                }
            }
            Console.Read();
        }
    }
}
