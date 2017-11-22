using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            // low level way
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            // better, smarter way!
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
