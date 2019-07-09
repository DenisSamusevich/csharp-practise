using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_letters_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите английское слово");
            string world = Console.ReadLine();
            int s = 0;
            for (int i = 0; i < world.Length; i++)
            {
                if (world[i] == "a")
                    s += 1;
         
            }
            if (s == 0)
                Console.WriteLine("В данном слове нет букв 'a'");
            Console.WriteLine("В данном слове " + s + " букв 'a'");
        }
    }
}
