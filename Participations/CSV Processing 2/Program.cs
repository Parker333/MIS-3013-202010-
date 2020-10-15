using System;
using System.Collections.Generic;
using System.Data.Common;
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
            string filepath = @"C:\Users\Parker\source\repos\MIS-3013-202010-\Participations\CSV Processing 2\SalesJan2009.csv";

            string[] lines = File.ReadAllLines(filepath);

            //Transaction_date,Product,Price,Payment_Type,Name,City,State,Country,Account_Created,Last_Login,Latitude,Longitude
            //Tran data = 0
            //Visa = 3
            //Name = 4
            //USA = 7

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] colums = line.Split(',');
                if (colums[3] == "Visa" && colums[7] == "United States")
                {
                    Console.WriteLine(colums[4]);
                    Console.WriteLine(colums[0]);
                }
            }
       
            Console.ReadKey();
        }
    }
}
