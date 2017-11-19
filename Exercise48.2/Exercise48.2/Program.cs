using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise48._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            string entry = "";

            do
            {
                Console.WriteLine("Enter a number, or ok to exit: ");
                entry = Console.ReadLine();
                if (entry !=  "ok")
                {
                    sum += Convert.ToInt32(entry);
                }
            } while (entry != "ok");

            Console.WriteLine("The sum is " + sum);
        }
    }
}
