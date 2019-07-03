using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short sht = 10;
            object o = sht;
            System.SByte shrt = (System.SByte)(short)o;
            System.Console.WriteLine(shrt);
            System.Console.WriteLine(shrt.GetType());
        }
    }
}
