using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int indexMax = 0;
            Random rand = new Random();
            int[] numbers = new int[13];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(50);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                    indexMax = i;
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("\t" + numbers[i]);
            }
            Console.WriteLine("\nMax = "+ max);
            Console.WriteLine("\nMax index = " + indexMax);
            Console.Read();
        }
    }
}
