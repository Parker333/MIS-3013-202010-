using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> ExamGrades = new List<double>();
            string answer;
            

            do
            {
                Console.WriteLine("Please enter your exam grade.");
                ExamGrades = Console.ReadLine();

                ExamGrades.Add(ExamGrades);

                Console.WriteLine("Do you have another exam grade?");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            //I don't understand how this isn't working.Tried for a hot second but it's almost due so I'll stop here.



            Console.ReadKey();
        }
    }
}
