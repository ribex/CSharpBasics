using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // line below same as: int[] numbers = new int[3];
            var numbers = new int[3];
            numbers[0] = 1;
            // numbers[1] = 2;
            // numbers[2] = 3;

            Console.WriteLine(numbers[0]); // 1
            Console.WriteLine(numbers[1]); // 0
            Console.WriteLine(numbers[2]); // 0

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]); // True
            Console.WriteLine(flags[1]); // False
            Console.WriteLine(flags[2]); // False

            var names = new string[3] {"Jack", "John", "Mary"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }
    }
}
