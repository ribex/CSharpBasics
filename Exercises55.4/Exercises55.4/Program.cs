using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises55._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            do
            {
                Console.WriteLine("Enter a number or type Quit to exit.");
                var entry = Console.ReadLine();
                if (entry == "Quit")
                {
                    break;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(entry));
                }
            } while (true);

            var uniques = new List<int>();

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }

            foreach (var unique in uniques)
            {
                Console.WriteLine(unique);
            }
        }
    }
}

