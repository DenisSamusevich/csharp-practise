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
            object o = (object)sht;
          

            System.SByte shrt2 = (System.SByte)o;
            System.Console.WriteLine(shrt.GetType());
        }
    }
}
