using System;
using System.Reflection.Metadata;

namespace Time_to_burn_calories
{
    class Program
    {
        static void Main(string[] args)
        {
            const double CalPM = 3.9;

            Console.WriteLine("How many calories do you wish to burn this workout?");
            double goal = Convert.ToDouble(Console.ReadLine());

            double calories = 0;
            int minutes = 0;

            do
            {
                minutes++;
                calories = calories + CalPM;
                Console.WriteLine($"After {minutes} minutes, you have burned {calories.ToString("N2")} calories.");

            } while (calories < goal);
  
        }
    }
}
