//Find the Longest Word in a Sentence

using System;
using System.Collections.Generic;

namespace Week.Task_for_my_week;


public class Longest_Wordcgfv
{
    public static void Find_Longest_Word()
    {
        Console.Write("What is your sentence: ");
        string sentence = Console.ReadLine();
        
        string[] sentence_list = sentence.Split(" ");

        int count = 0;
        string return_word = "";

        foreach (string word in sentence_list)
        {
            int word_len = word.Length;

            if (word_len > count)
            {
                count = word_len;
                return_word = word;
            }
        }
        
        Console.WriteLine($"Longest word is {return_word}, with {count} symbols");
    }
}
