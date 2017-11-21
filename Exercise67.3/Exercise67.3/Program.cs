using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise67._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time in the 24-hour time format (e.g. 19:45): ");

            var entry = Console.ReadLine();

            if (String.IsNullOrEmpty(entry))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var hourMin = entry.Split(':');
            var hour = Convert.ToByte(hourMin[0]);
            var minute = Convert.ToByte(hourMin[1]);

            if ((hour > 0 && hour < 24) && (minute >= 0 && minute < 60))
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }

        }
    }
}
