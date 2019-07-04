using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            var daytime = DateTime.Now.TimeOfDay;
            Console.WriteLine(daytime);
            var time_hour = daytime.Hours; ;
            Console.WriteLine(time_hour);

            if ((time_hour >= 9) & (time_hour <= 12))
                Console.WriteLine("Good morning, guys");
            else if (time_hour > 12 & time_hour <= 15)
                Console.WriteLine("Good day, guys");
            else if (time_hour > 15 & time_hour <= 22)
                Console.WriteLine("Good evening, guys");
 
            Console.Read();
        }
    }
}
