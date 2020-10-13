using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Parker_Hallows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a sentance.");
            string sentence = Console.ReadLine();
            int vowels = 0;
            int consonants = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'A' || sentence[i] == 'e' || sentence[i] == 'E' || sentence[i] == 'i' || sentence[i] == 'I' || sentence[i] == 'o' || sentence[i] == 'O' || sentence[i] == 'u' || sentence[i] == 'U')
                {
                    vowels++;
                }
                else if (sentence[i] >= 'a' && sentence[i] >= 'z'|| sentence[i] >= 'A' && sentence[i] >='Z')
                {
                    consonants++;
                }
            }
            Console.WriteLine($"There were {vowels} vowels in the sentence.");
            Console.WriteLine($"There were {consonants} conconants in the sentence.");

        }
    }
}
