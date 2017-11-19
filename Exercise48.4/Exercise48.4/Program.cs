using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise48._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numberToGuess = random.Next(1, 10);
            // Console.WriteLine("Number to guess is " + numberToGuess);
            var count = 0;
            bool won = false;
            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                var guess = Convert.ToInt16(Console.ReadLine());
                if (guess == numberToGuess)
                {
                    Console.WriteLine("You won");
                    won = true;
                    break;
                }
                count++;
            } while (count < 4);

            if (won == false)
            {
                Console.WriteLine("You lost");
            }
        }
    }
}
