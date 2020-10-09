using System;
using System.Dynamic;

namespace I337_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a sentence");
            string sentence = Console.ReadLine();
            string uppercase = sentence.ToUpper();
            

            var replace = uppercase.Replace('A', '4').Replace('E', '3').Replace('S', '$').Replace('T', '7').Replace('O','0').Replace('P','[]D');

            Console.WriteLine(replace);

            
        }
    }
}
