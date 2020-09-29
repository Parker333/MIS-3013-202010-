using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentIds = new int[3];
            double[] gpas = new double[3];

            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;

            gpas[0] = 1.75;
            gpas[1] = 2.99;
            gpas[2] = 4.00;

            for (int i = 0; i < studentIds.Length; i++)
            {
                int studentId = studentIds[i];
                Console.WriteLine(studentId);
            }

            foreach (int studentId in studentIds)
            {
                Console.WriteLine(studentId);
            }

            Console.WriteLine("please pick an ID to display the GPA");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentIds.Length; i++)
            {
                int studentId = studentIds[i];
                if (studentId == id)
                {
                    double gpa = gpas[i];
                    Console.WriteLine($"");
                    break;


                }
            }


            Console.ReadKey();
        }
    }
}
