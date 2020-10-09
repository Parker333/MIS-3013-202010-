using System;

namespace Tutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int Randomnumber1 = rnd.Next(1, 51);
            int Randomnumber2 = rnd.Next(1, 51);

            double equation = Randomnumber1 + Randomnumber2;
            Console.WriteLine($"{Randomnumber1} + {Randomnumber2} =?");
            double guess = Convert.ToDouble(Console.ReadLine());

            while (equation != guess)
            {
                Console.WriteLine("Your guess was not right, please try again.");
                Console.WriteLine($"{Randomnumber1} + {Randomnumber2} =?");
                guess = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Congradulations, your guess was correct!");
     
        }
    }
}
