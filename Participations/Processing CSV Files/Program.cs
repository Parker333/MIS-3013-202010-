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
            string filepath = @"sales_data_sample.csv";

            string[] lines = File.ReadAllLines(filepath);

            double sum = 0;
            double sum2003 = 0;
            double sum2004 = 0;
            double sum2005 = 0;
            double jan = 0;
            double feb = 0;
            double march = 0;
            double april = 0;
            double may = 0;
            double june = 0;
            double july = 0;
            double aug = 0;
            double sept= 0;
            double oct = 0;
            double nov = 0;
            double dec = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                double sale = Convert.ToDouble(pieces[4]);
                string year = pieces[9];
                
                if (pieces[6].Trim().ToLower() == "shipped")
                {
                    if (year == "2003")
                    {
                        sum2003 += sale;
                    }
                    else if (year == "2004")
                    {
                        sum2004 += sale;
                    }
                    else
                    {
                        sum2005 += sale;
                    }

                    sum += sale;
                }

            }

            Console.WriteLine($"The total sales for shipped items in 2003 is {sum2003.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in 2004 is {sum2004.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in 2005 is {sum2005.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in January is {jan.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in February is {feb.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in March is {march.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in April is {april.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in May is {may.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in June is {june.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in July is {july.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in August is {aug.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in Septemper is {sept.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in October is {oct.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in November is {nov.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in December is {dec.ToString("C")}!");

            Console.WriteLine($"Total sales of shipped orders is {sum.ToString("C2")}.");

            Console.ReadKey();




            Console.ReadKey();
        }
    }
}
