using System;

namespace Coin_Flip
{
    class Program
    {
        const string DEVELOPER = "Parker Hallows";
        const int Heads = 1;
        const int Tails = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Heads or Tails >>");
            string answer = Console.ReadLine();

            Random rnd = new Random();
            int result = rnd.Next(0, 2); // Generates a number that can be 0 or 1
            if (result == 0)
            {
                Console.WriteLine("The flip was tails");
            }
            else if (result == 1)
            {
                Console.WriteLine("The flip was heads");
            }

            // You can either have one if statement with multiple checks
            // or you can have two different if statements and either
            // convert their answer to an int or the random number (result)
            // to a string

            if (result == 1
                && answer == "Heads")
            {
                Console.WriteLine("YOU GUSSED It");
            }
            else if (result == 0
                && answer == "Tails")
            {
                Console.WriteLine("YOU GUSSED It");
            }
            else
            {
                Console.WriteLine("YOU'RE WRONG");
            }

            Console.WriteLine(DEVELOPER);






        }
    }
}
