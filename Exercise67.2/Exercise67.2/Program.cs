using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise67._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by hyphens (-): ");

            var entry = Console.ReadLine();

            if (String.IsNullOrEmpty(entry))
            {
                return;
            }

            Console.WriteLine(DuplicateNumberDetector(entry));
        }

        public static string DuplicateNumberDetector(string entry)
        {
            var numbers = entry.Split('-');

            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    return("Duplicate");
                }
            }

            return(null);
        }
    }
}
