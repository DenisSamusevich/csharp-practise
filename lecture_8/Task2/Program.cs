using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] massiv = new object[3];
            int num32 = 32;
            char A = 'A';
            string hello = "Hello";
            massiv[0] = num32;
            massiv[1] = A;
            massiv[2] = hello;
            Console.WriteLine(massiv[0]);
            Console.WriteLine(massiv[1]);
            Console.WriteLine(massiv[2]);
            Console.ReadLine();


        }
    }
}
