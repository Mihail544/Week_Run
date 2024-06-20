//Palindrome Check

using System;
using System.Collections.Generic;

namespace Week.Task_for_my_week;

public class Palindrome_Check 
{
    public static void Palindrome_Checker()
    {
        
        Console.Write("Give me your word: ");
        string word = Console.ReadLine();
        string reverset_word = "";

        for (int i = word.Length - 1; i >= 0; i -= 1)
        {
            reverset_word += word[i];
        }
        
        if (word == reverset_word) {Console.WriteLine("Your word is Palindrome");}

        else
        {Console.WriteLine("Your word is not a Palindrome.");}

    }
}