using System;

namespace SumOf3
{
    class Program
    {
        const double LUCKY_NUMBER = 7.777;
        static void Main(string[] args)
        {
            string numbner1 = "1";
            string number2 = "5.5";
            string number3 = "1.277";

            Console.WriteLine("Please enter the number 1");
            numbner1 = Console.ReadLine();

            Console.WriteLine("Please enter the number 5.5");
            number2 = Console.ReadLine();

            Console.WriteLine("Please enter the number 2");
            number3 = Console.ReadLine();

            Console.WriteLine("What is the sum of the 3 number?");
            string SumOf = Console.ReadLine();
            double Sum = Convert.ToDouble(SumOf);



            Console.WriteLine();
            


            
        }
    }
}
