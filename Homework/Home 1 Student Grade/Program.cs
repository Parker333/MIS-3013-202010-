using System;
using System.Runtime.CompilerServices;

namespace Parker_Hallows
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name = "Parker";
            string last_name = "Hallows";
            string student_id = "111111";
            double homework = 0;
            double participation = 0;
            double quiz = 0;
            double midterm = 0;
            double final = 0;

            Console.WriteLine("What is your first name?");
            first_name = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            last_name = Console.ReadLine();

            Console.WriteLine("What is your student ID?");
            student_id = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            homework = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participations?");
            participation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            quiz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            midterm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final?");
            final = Convert.ToDouble(Console.ReadLine());

            double final_grade = ((homework + participation + quiz + midterm + final) / 500);

            Console.WriteLine(first_name + " " + last_name + " " + "(" + student_id + ")," + " " + "your final grade is" + " " + final_grade.ToString("P2") );

        }
    }
}

