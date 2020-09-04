using Microsoft.VisualBasic;
using System;

namespace CoonditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 0;
            double distance = 0;
            string hazardousResponse = "";
            bool containsHazardous = false;

            Console.WriteLine("What is the weight of your shipment in pounds? >>");
            string response = Console.ReadLine();
            weight = Convert.ToDouble(response);

            Console.WriteLine("What is distance of your shipment in miles? >>");
            distance = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Does your shipment contain any hazardous materials, yes or no? >>");
            hazardousResponse = Console.ReadLine();

            if (hazardousResponse == "yes")
            {
                containsHazardous = true;

            }
            else if (hazardousResponse == "no")
            {
                containsHazardous = false;
            }
            else
            {
                Console.WriteLine("INVALID INPUT. GOODBYE!");
                return;
            }

            double quote = (0.55 * distance) + (.73 * weight);
            double hazardousCost = 0;

            if (containsHazardous == true)
            {
                hazardousCost = 0.15 * weight;
            }
            else
            {
                hazardousCost = 0;
            }

            double netTotal = quote + hazardousCost;
            double discount = 0;

            if (distance < 1500 && weight > 500) ;
            {
                 discount = netTotal * 0.10;
            }

            double total = netTotal - discount;

            Console.WriteLine();
            Console.WriteLine("Quote:           " + quote.ToString("C"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hazardous Cost:  " + hazardousCost.ToString("C"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Net Total:       " + netTotal.ToString("C"));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Discount:        " + discount.ToString("C"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Total:           {total.ToString("C")}");


        
        
        
        
        
        
        
        
        
        }
    }
}
