using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteThings = new List<string>();
            string answer;

            do
            {
                Console.WriteLine("Please enter one of your favorite things");
                string favoriteThing = Console.ReadLine();

                favoriteThings.Add(favoriteThing);

                Console.WriteLine("Do you have another favorite thing?");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            Random rand = new Random();
            int index = rand.Next(0, favoriteThings.Count);

            Console.WriteLine(favoriteThings[index]);

            foreach (var ft in favoriteThings)
            {

            }







            Console.ReadKey();
        }
    }
}
