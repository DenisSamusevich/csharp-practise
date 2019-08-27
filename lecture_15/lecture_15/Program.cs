using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input string");
            string str = Console.ReadLine();
            string newString = str.StringfiveSymbol();
            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
