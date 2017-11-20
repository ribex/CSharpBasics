using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise55._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five unique numbers, one per line.");
            var numbers = new int[5];
            var count = 0;
            do
            {
                var entry = Convert.ToInt32(Console.ReadLine());
                var index = Array.IndexOf(numbers, entry);
                if (index < 0)
                {
                    numbers[count] = entry;
                    count++;
                }
                else
                {
                    Console.WriteLine("Duplicate number, please retry your entry.");
                }
            } while (count < 5);

            Array.Sort(numbers);
            for (var i = 0; i < 5; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
