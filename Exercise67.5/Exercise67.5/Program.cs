using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise67._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an English word: ");
            var entry = Console.ReadLine();

            Console.WriteLine(VowelCount(entry));
        }

        public static int VowelCount(string entry)
        {
            var lower = entry.ToLower();
            var vowelCount = 0;
            foreach (char letter in lower)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowelCount++;
                }
            }
            return (vowelCount);
        }
    }
}
