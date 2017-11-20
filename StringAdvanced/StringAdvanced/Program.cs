using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Rebecca Wagaman ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); // removes all leading and trailing whitespace
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index).Trim();
            var lastName = fullName.Substring(index + 1).Trim();

            Console.WriteLine("firstName: '{0}'", firstName);
            Console.WriteLine("lastName: '{0}'", lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Rebecca", "Becky"));

            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid"); // Invalid
            }

            if (String.IsNullOrEmpty(""))
            {
                Console.WriteLine("Invalid"); // Invalid
            }

            if (String.IsNullOrEmpty(" "))
            {
                Console.WriteLine("Invalid"); // no message, because a space is not empty
            }

            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid"); // Invalid
            }

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid"); // Invalid
            }

            var str = "25";
            var age = Convert.ToByte(str); // no person will be over 255 years old so this is sufficient
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C")); // Currency $29.95
            Console.WriteLine(price.ToString("C")); // Currency without decimal $30

        }
    }
}
