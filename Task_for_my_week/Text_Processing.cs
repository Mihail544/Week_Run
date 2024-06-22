//Text Processing with Lists


using System;
using System.Collections.Generic;


namespace Week.Task_for_my_week;

public class Text_Processing
{
    public static void Text_List_Processing()
    {
        Console.Write("Give me data: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(" ");
        List<string> words_list = new List<string>(words);

        

        

        for (int index = 0; index < words.Length; index += 1)
        {words_list[index] = words_list[index].ToLower();}

        words_list.Sort();
        
        words_list = words_list.Distinct().ToList();

        string final_result = string.Join(" ", words_list);
        
        Console.WriteLine($"Your answer is: {final_result}");
        

    }
}