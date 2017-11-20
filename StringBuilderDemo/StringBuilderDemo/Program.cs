using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10) // methods can be appended because the return value of each is a StringBuilder
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 5)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First character: " + builder[0]);
        }
    }
}
