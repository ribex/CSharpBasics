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
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
        }

    }
}
