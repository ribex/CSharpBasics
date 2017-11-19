using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises42._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            var num1 = Int32.Parse(Console.ReadLine());
            var num2 = Int32.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("The maximum value is " + num1);
            }
            else
            {
                Console.WriteLine("The maximum value is " + num2);
            }
        }
    }
}
