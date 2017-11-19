using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit:");
            var limit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the car speed:");
            var speed = Int32.Parse(Console.ReadLine());

            if (speed <= limit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var demerit = (speed - limit) / 5;
                if (demerit > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine(demerit);
                }
            }
        }
    }
}
