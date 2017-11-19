using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the image: ");
            var width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the image: ");
            var height = Int32.Parse(Console.ReadLine());
            if (height > width)
            {
                Console.WriteLine("The image is portrait.");
            }
            else
            {
                Console.WriteLine("The image is landscape.");
            }
        }
    }
}
