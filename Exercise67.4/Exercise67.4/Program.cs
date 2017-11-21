using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise67._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words separated by spaces: ");

            var entry = Console.ReadLine();

            var lower = entry.ToLower();

            var words = lower.Split(' ');

            var output = new List<string>();

            foreach (var word in words)
            {
                output.Add(word.First().ToString().ToUpper() + word.Substring(1));
            }

            var pascalCase = String.Join("", output);

            Console.WriteLine(pascalCase);
        }
    }
}
