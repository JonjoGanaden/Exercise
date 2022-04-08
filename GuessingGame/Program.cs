using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int r = random.Next(1, 100);

            int Guess = 0;
            int Lives = 6;

            Console.WriteLine("I am thinking of a number between 1 and 100");

            while (Guess != r)
            {
                Guess =  Convert.ToInt32(Console.ReadLine());

                if (Guess < r)
                {
                    Console.WriteLine("number is higher");
                    Lives -= 1;
                    Console.WriteLine("You have {0} lives", Lives);
                }
                else if (Guess > r)
                {
                    Console.WriteLine("Number is lower");
                    Lives -= 1;
                    Console.WriteLine("You have {0} lives", Lives);
                }

                if (Lives == 0)
                {
                    Console.WriteLine("Game over, the number was " + r);
                    break;
                }

                if (Guess == r)
                {
                    Console.WriteLine("Well done! The answer was " + r);
                    break;
                }

            }

            Console.ReadLine();

        }
    }
}
