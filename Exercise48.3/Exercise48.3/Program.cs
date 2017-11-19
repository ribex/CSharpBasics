using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise48._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            for (var i = number; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
}
