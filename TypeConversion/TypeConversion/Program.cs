using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "1234";
            byte b = Convert.ToByte(number);
            Console.WriteLine(b);
        }
    }
}
