using System;
using System.Reflection.Metadata;

namespace Parker_Hallows
{
    class Program
    {
        static void Main(string[] args)
        {
            const double CalPM = 3.9;

            Console.WriteLine("How many calories do you wish to burn this workout session?");
            double goal = Convert.ToDouble(Console.ReadLine());

            double calories = 0;
            int minutes = 0;

            do
            {
                minutes++;
                calories = calories + CalPM;
                Console.WriteLine($"After {minutes} minutes, you have burned {calories.ToString("N1")} calories.");

            } while (calories < goal);
  
        }
    }
}
