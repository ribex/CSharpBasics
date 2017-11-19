using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("It's a beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect to go to the beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}
