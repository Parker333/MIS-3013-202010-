using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parker_Hallows
{
    class Program
    {
        static void Main(string[] args)
        {
            double tp = 0;

            Console.WriteLine("Please answer the following true or false questions");

            Console.WriteLine("Oklahoma is a state");
            string Oklahoma = Convert.ToString(Console.ReadLine());

            if (Oklahoma == "true")
            {
                tp = tp + 1;
            }
            else if (Oklahoma == "false") 
            {
                tp = tp + 0;
            }
            else
            {
                Environment.Exit(-900);
            }

            Console.WriteLine("10 + 10 is 21");
            string TwentyOne = Convert.ToString(Console.ReadLine());


            if (TwentyOne == "true")
            {
                tp = tp + 0;
            }
            else if (TwentyOne == "false")
            {
                tp = tp + 1;
            }
            else
            {
                Environment.Exit(-900);
            }

            Console.WriteLine("Brazil is in Asia");
            string Brazil = Convert.ToString(Console.ReadLine());


            if (Brazil  == "true")
            {
                tp = tp + 0;
            }
            else if (Brazil == "false")
            {
                tp = tp + 1;
            }
            else
            {
                Environment.Exit(-900);
            }

            Console.WriteLine("There are 50 states in the US");
            string States = Convert.ToString(Console.ReadLine());


            if (States == "true")
            {
                tp = tp + 1;
            }
            else if (States == "false")
            {
                tp = tp + 0;
            }
            else
            {
                Environment.Exit(-900);
            }

            Console.WriteLine("Mexico is the biggest country in the world");
            string Mexico = Convert.ToString(Console.ReadLine());


            if (Mexico == "true")
            {
                tp = tp + 0;
            }
            else if (Mexico == "false")
            {
                tp = tp + 1;
            }
            else
            {
                Environment.Exit(-900);
            }

            double pc = (tp / 5);


            Console.WriteLine(" ");
            Console.WriteLine($"Your total score was a {tp} out of 5.");
            Console.WriteLine("You answered" + " " + pc.ToString("P2") + " " + "of the questions correctly.");

            Console.ReadKey();
        }
    }
}
