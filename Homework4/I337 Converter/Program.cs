using System;
using System.Dynamic;

namespace Parker_Hallows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a sentence.");
            string sentence = Console.ReadLine();
            string uppercase = sentence.ToUpper();
            string sentenceA = "";
            string sentenceE = "";
            string sentenceH = "";
            string sentenceS = "";
            string sentenceT = "";
            string sentenceU = "";
            string sentenceO = "";
            string sentenceP = "";

            for (int i = 0; i < uppercase.Length; i++)
            {
                sentenceA = uppercase.Replace("A", "4");
                sentenceE = sentenceA.Replace("E","3");
                sentenceH = sentenceE.Replace("H","|-|");
                sentenceS = sentenceH.Replace("S","$");
                sentenceT = sentenceS.Replace("T","7");
                sentenceU = sentenceT.Replace("U","|_|");
                sentenceO = sentenceU.Replace("O","0");
                sentenceP = sentenceO.Replace("P","[]D");

            }

            if (sentenceP.Contains('!'))
            {
                Console.WriteLine(sentenceP);
            }
            else
            {
                Console.WriteLine(sentenceP+"!");
            }

            
            
        }
    }
}
