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
            Console.WriteLine(IsConsecutive(entry));
        }

        public static string IsConsecutive(string entry)
        {
            var values = entry.Split('-');
            for (int i = 0; i < values.Length - 1; i++)
            {
                if (Math.Abs(Convert.ToInt32(values[i]) - Convert.ToInt32(values[i + 1])) != 1)
                {
                    return ("Not Consecutive");
                }
            }
            return ("Consecutive");
        }
    }
}
