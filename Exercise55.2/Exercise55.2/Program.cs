using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise55._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter their name. Use an array to reverse the name and then store 
            // the result in a new string. Display the reversed name on the console.
            Console.WriteLine("Enter your name and I'll reverse it: ");
            var name = Console.ReadLine().ToCharArray();

            Array.Reverse(name);

            var reversed = new string(name);

            Console.WriteLine("Your name has been reversed: " + reversed);
        }
    }
}
