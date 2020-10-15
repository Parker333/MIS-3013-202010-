using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Processing_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            string userinput = "";

            do
            {
                Console.WriteLine("Do you want to add to number?");
                userinput = Console.ReadLine();
                number++;

            } while (userinput=="Yes");

            Console.WriteLine(number);
            
 

           






            Console.ReadKey();
        }
    }
}
