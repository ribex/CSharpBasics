using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise48._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by commas: ");
            var numbers = Console.ReadLine().Split(',');

            var max = Int32.MinValue;
            foreach (var number in numbers)
            {
                max = (max > Convert.ToInt32(number)) ? max : Convert.ToInt32(number);
            }
            Console.WriteLine(max);
        }
    }
}
