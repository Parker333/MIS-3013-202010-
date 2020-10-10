using System;

namespace Parker_Hallows
{
    class Program
    {
        static void Main(string[] args)
        {
            double tuition = 12000;
           const double increaseby = 0.05;

            for (int i = 1; i < 8; i++)
            {
                double tuitionincrease = tuition * increaseby;
                tuition = tuition + tuitionincrease;
                Console.WriteLine($"The tuition after year {i} will be {tuition.ToString("C0")}");
            }
        }
    }
}
