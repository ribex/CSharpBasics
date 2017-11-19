using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a; // value of a copied to b
            b++; // a remains 10
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1; // array2 references same memory location as the array stored in array1
            array2[0] = 0; // changes value in the memory location referenced by both array2 and array1
            Console.WriteLine(array1[0]); // 0
            Console.WriteLine("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]); // 0, 0
        }
    }
}
