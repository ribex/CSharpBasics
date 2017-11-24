using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise75._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\test\testfile.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists!");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
            var content = File.ReadAllText(path);

            var words = content.Split(' ');
            var wordCount = words.Count();

            Console.WriteLine("The file contains " + wordCount + " words.");
        }
    }
}
