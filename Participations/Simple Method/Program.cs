using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = "";

            do
            {
                   Console.WriteLine("Please choose a dog, monkey, or goat.");
                    animal = Convert.ToString(Console.ReadLine());

                if (animal == "dog")
                {
                    Console.WriteLine("A dog says woof woof");
                    Console.WriteLine(" ");

                }
                else if (animal == "monkey")
                {
                    Console.WriteLine("A monkey says Oo Oo Ah Ah");
                    Console.WriteLine(" ");

                }
                else if (animal == "goat")
                {
                    Console.WriteLine(" A goat says Bahhhh");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Please input one of the 3 animals");
                }

            } while ((animal != "dog" || animal != "monkey" || animal != "goat"));
 


            Console.ReadKey();
           

        }
    }
}
