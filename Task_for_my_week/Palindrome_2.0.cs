//Palindrome_2.0

using System;
using System.Collections.Generic;

namespace Week.Task_for_my_week;

public class Palindrome_2_0
{
    public static void New_Palindrome_Check()
    {
        Console.Write("Give me your word: ");
        string input = Console.ReadLine();
        string reversed_word = string.Join("",input.Reverse());
        
        if (input == reversed_word) {Console.WriteLine($"Your word '{input}' is Palindrome");}

        else
        {
            Console.WriteLine($"Your word '{input}' is just a normal word.");
        }

    }
}