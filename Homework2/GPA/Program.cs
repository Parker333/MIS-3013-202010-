using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parker_Hallows
{ 
    class Program
    {
        private const double V = 89.5;

        static void Main(string[] args)
        {
            const double CH = 3;
            double A = 4;
            double B = 3;
            double C = 2;
            double D = 1;
            double F = 0;
            double accp;
            double markp;
            double ecop;
            double misp;


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
                accp = A * CH;
                Console.WriteLine("Your letter grade for Accounting is A");

            }
            else if (acc >= 79.5)
            {
                accp = B * CH;
                Console.WriteLine("Your letter grade for Accounting is B");
            }
            else if (acc >= 69.5)
            {
                accp = C * CH;
                Console.WriteLine("Your letter grade for Accounting is C");
            }
            else if (acc >= 59.5)
            {
                accp = D * CH;
                Console.WriteLine("Your letter grade for Accounting is D");
            }
            else
            {
                accp = F * CH;
                Console.WriteLine("Your letter grade for Accounting is F");
            }

            if (mark >= 89.5)
            {
                markp = A * CH;
                Console.WriteLine("Your letter grade for Marketing is A");

            }
            else if (mark >= 79.5)
            {
                markp = B * CH;
                Console.WriteLine("Your letter grade for Marketing is B");
            }
            else if (mark >= 69.5)
            {
                markp = C * CH;
                Console.WriteLine("Your letter grade for Marketing is C");
            }
            else if (mark >= 59.5)
            {;
                markp = D * CH;
                Console.WriteLine("Your letter grade for Marketing is D");
            }
            else
            {
                markp = F * CH;
                Console.WriteLine("Your letter grade for Marketing is F");
            }
            if (eco >= 89.5)
            {
                ecop = A * CH;
                Console.WriteLine("Your letter grade for Economics is A");

            }
            else if (eco >= 79.5)
            {
                ecop = B * CH;
                Console.WriteLine("Your letter grade for Economics is B");
            }
            else if (eco >= 69.5)
            {  
                ecop = C * CH;
                Console.WriteLine("Your letter grade for Economics is C");
            }
            else if (eco >= 59.5)
            {
                ecop = D * CH;
                Console.WriteLine("Your letter grade for Economics is D");
            }
            else
            {
                ecop = F * CH;
                Console.WriteLine("Your letter grade for Economics is F");
            }
            if (mis >= 89.5)
            {
                misp = A * CH;
                Console.WriteLine("Your letter grade for MIS is  A");
            }
            else if (mis >= 79.5)
            {
                misp = B * CH;
                Console.WriteLine("Your letter grade for MIS is B");
            }
            else if (mis >= 69.5)
            {
                misp = C * CH;
                Console.WriteLine("Your letter grade for MIS is C");
            }
            else if (mis >= 59.5)
            {
                misp = D * CH;
                Console.WriteLine("Your letter grade for MIS is D");
            }
            else
            {
                misp = F * CH;
                Console.WriteLine("Your letter grade for MIS is F");
            }

            double TPE = accp + markp + ecop + misp;
            double GPA = TPE / 12;

            Console.WriteLine("Your overall GPA for the semester is a" + " " + GPA.ToString("N2"));































            Console.ReadKey();
        }
    }
}
