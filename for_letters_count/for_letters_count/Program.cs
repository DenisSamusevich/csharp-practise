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
            Console.WriteLine("Input english word");
            string word = Console.ReadLine();
            int s = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a'|| word[i]=='A')
                    s += 1;
            }
            if (s == 0)
                Console.WriteLine("Word not have 'a'");
            else
                Console.WriteLine("Word have " + s + " 'a'");
            Console.Read();
        }
    }
}
