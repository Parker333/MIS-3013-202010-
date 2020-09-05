using System;

namespace SumOf3
{
    class Program
    {
        const double LUCKY_NUMBER = 7.777;
        static void Main(string[] args)
        {
            double number1 = 0;
            bool number11 = false;
            double number2 = 0;
            bool number21 = false;
            double number3 = 0;
            bool number31 = false;

            Console.WriteLine("Please enter the number 1. >>");
            number1 = Convert.ToDouble(Console.ReadLine());

            if (number1 == 1)
            {
                number11 = true;
            }
            else
            {
                Console.WriteLine("INVALD INPUT. GOODBYE!");
                return;
            }

            Console.WriteLine("Please enter the number 5.5. >>");
            number2 = Convert.ToDouble(Console.ReadLine());

            if (number2 == 5.5)
            {
                number21 = true;
            }
            else
            {
                Console.WriteLine("INVALD INPUT. GOODBYE!");
                return;
            }
            Console.WriteLine("Please enter any other number besides 1 or 5.5. >>");
            number3 = Convert.ToDouble(Console.ReadLine());

            if (number3 != 1)
            {
                number31 = true;
            }
            else
            {
                Console.WriteLine("INVALD INPUT. GOODBYE!");
                return;
            }
            if (number3 != 5.5)
            {
                number31 = true;
            }
            else
            {
                Console.WriteLine("INVALD INPUT. GOODBYE!");
                return;
            }
            double sum = (number1 + number2 + number3);
            double megevalue = (sum * LUCKY_NUMBER);

            Console.WriteLine("Sum: " + sum.ToString("F3"));
            Console.WriteLine("Lucky Number: " + megevalue.ToString("F3"));



            }
        }
    }


            
        
    

