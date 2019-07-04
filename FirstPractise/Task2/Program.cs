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
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();

            arrayList.Add(45); //true, boxing
            arrayList.Add(true); //true, boxing
            arrayList.Add("Hello!"); //false
            arrayList.Add(23.45); //true, boxing
        }
    }
}
