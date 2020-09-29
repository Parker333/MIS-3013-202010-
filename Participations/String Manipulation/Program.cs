using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    class Program
    {
        static string programming = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {

            Console.WriteLine(programming);
            Console.WriteLine("");

            Console.WriteLine("What word do you want to find in the sentence above?");
            string find = Console.ReadLine();

            Console.WriteLine("What word do you want to change it to?");

            string replace = Console.ReadLine();

            if (programming.Contains(find) == true)
            {
                string newMessage = programming.Replace(find, replace);
                Console.WriteLine(newMessage);
            }
            else
            {
                Console.WriteLine($"sorry, I couldn't find your word {find}.");

                for (int i = find.Length - 1; i >= 0; i--)
                {
                    Console.Write(find[i]);
                }
            }


            Console.ReadKey();
        }
    }
}
