using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parker_Hallows
{ 
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your grade percentage for Accounting");
            double acc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your grade percentage for Marketing");
            double mark = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your grade percentage for Economics");
            double eco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your grade percentage for MIS");
            double mis = Convert.ToDouble(Console.ReadLine());

            if (acc >= 89.5)
            {
                 Console.WriteLine("Your letter grade for Accounting is A");   
            }
            else if (acc >= 79.5)
            {
                Console.WriteLine("Your letter grade for Accounting is B");
            }
            else if (acc >= 69.5)
            {
                Console.WriteLine("Your letter grade for Accounting is C");
            }
            else if (acc >= 59.5)
            {
                Console.WriteLine("Your letter grade for Accounting is D");
            }
            else
            {
                Console.WriteLine("Your letter grade for Accounting is F");
            }

            if (mark >= 89.5)
            {
                Console.WriteLine("Your letter grade for Marketing is A");

            }
            else if (mark >= 79.5)
            {
                Console.WriteLine("Your letter grade for Marketing is B");
            }
            else if (mark >= 69.5)
            {
                Console.WriteLine("Your letter grade for Marketing is C");
            }
            else if (mark >= 59.5)
            {
                Console.WriteLine("Your letter grade for Marketing is D");
            }
            else
            {
                Console.WriteLine("Your letter grade for Marketing is F");
            }
            if (eco >= 89.5)
            {
                Console.WriteLine("Your letter grade for Economics is A");

            }
            else if (eco >= 79.5)
            {
                Console.WriteLine("Your letter grade for Economics is B");
            }
            else if (eco >= 69.5)
            {
                Console.WriteLine("Your letter grade for Economics is C");
            }
            else if (eco >= 59.5)
            {
                Console.WriteLine("Your letter grade for Economics is D");
            }
            else
            {
                Console.WriteLine("Your letter grade for Economics is F");
            }
            if (mis >= 89.5)
            {
                Console.WriteLine("Your letter grade for MIS is  A");

            }
            else if (mis >= 79.5)
            {
                Console.WriteLine("Your letter grade for MIS is B");
            }
            else if (mis >= 69.5)
            {
                Console.WriteLine("Your letter grade for MIS is C");
            }
            else if (mis >= 59.5)
            {
                Console.WriteLine("Your letter grade for MIS is D");
            }
            else
            {
                Console.WriteLine("Your letter grade for MIS is F");
            }

            
            































            Console.ReadKey();
        }
    }
}
