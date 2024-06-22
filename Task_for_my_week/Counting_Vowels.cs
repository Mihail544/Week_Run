//Counting Vowels and Consonants

using System;
using System.Collections.Generic;

namespace Week.Task_for_my_week
{
    public class Counting_Vowels
    {
        public static void Counting_Vowels_Consonants()
        {
            int vowelsNumber = 0;
            int consonantsNumber = 0;
            int symbols_number = 0;
            
            char[] vowels = {'a','o', 'u', 'e', 'i', 'A', 'O', 'U', 'E', 'I'};
            
            Console.Write("Give me data: ");
            string data = Console.ReadLine();

            foreach (char symbol in data)
            {
                if (char.IsLetter(symbol))
                {
                    if (Array.Exists(vowels, elemen => elemen == symbol))
                    {vowelsNumber += 1;}
                    
                    else
                    {consonantsNumber += 1;}
                }
                
                else
                {symbols_number += 1;}
            }
            
            Console.WriteLine($"Your data contains {vowelsNumber} vowels," + 
                              $" {consonantsNumber} consonants " +
                              $"and {symbols_number} different symbols.");
        }
    }
}
