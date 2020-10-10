using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing_CSV_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"sales_data_sample.cvs";

            string[] lines = File.ReadAllLines(filepath);

            double sum = 0;
            double sum2003 = 0;
            double sum2004 = 0;
            double sum2005 = 0;

            // I looked at what you put on github and don't understand it. I'll have to go back and rewatch the lectures to get more undstanding.
    



            Console.ReadKey();
        }
    }
}
