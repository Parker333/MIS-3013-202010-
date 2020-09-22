using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            string instanceOfString = "Hello World";

            instanceOfString = instanceOfString.ToUpper();
            for (int i = 0; i < instanceOfString.Length; i++)
            {
                char letter = instanceOfString[i];
                Console.WriteLine(letter);
            }


            Console.ReadKey();
        }
    }
}
