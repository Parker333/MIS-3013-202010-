using System;

namespace Parker_Hallows
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Randomnumber1 = rnd.Next(1, 51);
            int Randomnumber2 = rnd.Next(1, 51);
            double sum = Randomnumber1 + Randomnumber2;

            Console.WriteLine($"{Randomnumber1} + {Randomnumber2} =?");
            double guess = Convert.ToDouble(Console.ReadLine());

            while (sum != guess)
            {
                Console.WriteLine("Your guess was not right, please try again.");
                Console.WriteLine($"{Randomnumber1} + {Randomnumber2} =?");
                guess = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Congratulations, your guess was correct!");
     
        }
    }
}
