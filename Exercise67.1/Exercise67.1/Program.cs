using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise67._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by hyphens (-): ");
            string entry = Console.ReadLine();
            var values = entry.Split('-');
            var consecutive = true;

            for (int i = 0; i < values.Length - 1; i++)
            {
                if (Math.Abs(Convert.ToInt32(values[i]) - Convert.ToInt32(values[i + 1])) != 1)
                {
                    Console.WriteLine("Not Consecutive");
                    consecutive = false;
                    break;
                }
            }
            if (consecutive)
            {
                Console.WriteLine("Consecutive");
            }
        }
    }
}
