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
        static void Main(string[] args)
        {

            string programming = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

            Console.WriteLine(programming);
            Console.WriteLine("");

            Console.WriteLine("What word do you want to find in the sentence above?");
            string find = Convert.ToString(Console.ReadLine());

            Console.WriteLine("What word do you want to change it to?");
            string replace = Convert.ToString(Console.ReadLine());





            Console.ReadKey();
        }
    }
}
