using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a number for the minimum value.");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please pick a number for the maximum value.");
            int Y = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int number = rnd.Next(X, (Y + 1));

            int guesses = 0;
            double guess;

            do
            {
                guesses += 1;
                Console.WriteLine($"Please guess a number between or eqaul to your min ({X}) and max ({Y}).");
                guess = Convert.ToDouble(Console.ReadLine());

            } while (guess != number);

            Console.WriteLine(" ");
            Console.WriteLine($"The random number was {number} and your guess was {guess}, Congratulations!");
            Console.ReadKey();
        }
    }
}
