using System;
using System.Net.Http.Headers;

namespace Parker_Hallows
{
    class Program
    {
        const double Sales_Tax = 0.085;
        static void Main(string[] args)
        {
            double quantity = 0;
            double price = 0;
            string productname = "Name";


            Console.WriteLine("What is the product name of the item you are purchasing?");
            productname = Console.ReadLine();

            Console.WriteLine("How many" + " " + productname + "'s" + " " + "do you want to buy?");
            quantity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the price for each" + " " + productname + "?");
            price = Convert.ToDouble(Console.ReadLine());

            double subtotal = (quantity * price);
            double tax = (subtotal * Sales_Tax);
            double total = (subtotal + tax);

            Console.WriteLine(" ");
            Console.WriteLine("        " + "Your subtotal for your bill is " + subtotal.ToString("N2") + ".");
            Console.WriteLine("        " + "Your sales tax for your bill is " + tax.ToString("N2") + ".");
            Console.WriteLine("        " + "Your total for your bill is " + total.ToString("N2") + ".");


        }
    }
}
