using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise55._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a list of at least 5 numbers separated by commas: ");
            var numberList = new List<int>();

            do
            {
                var entry = Console.ReadLine();
                var numbers = entry.Split(',');

                if (numbers.Length < 5)
                {
                    Console.WriteLine("Invalid List");
                    Console.WriteLine("Please retry your list: ");
                    continue;
                }

                foreach (var number in numbers)
                {
                    numberList.Add(Convert.ToInt32(number));
                }

            } while (numberList.Count < 5);

            numberList.Sort();

            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(numberList[i]);
            }
        }
    }
}
