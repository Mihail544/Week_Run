//Reverse Words in a Sentence

using System;
using System.Collections.Generic;


namespace Week.Task_for_my_week;

public class Reverse_Sentence
{
    public static void Sentence_Reverser()
    {
        Console.Write("Your sentence please: ");
        string[] sentence = (Console.ReadLine()).Split();
        List<string> reverset_list = new List<string>();

        int count = sentence.Length -1;
        string result = "";
        
        foreach (string word in sentence)
        {   
            
            reverset_list.Add(sentence[count]);
            count -= 1;
        }

        result = string.Join(" ",reverset_list);

        Console.WriteLine(result);
        
    }
}


// using System;
// using System.Text;
//
// namespace Week.Task_for_my_week
// {
//     public class Reverse_Sentence
//     {
//         public static void Sentence_Reverser()
//         {
//             Console.Write("Your sentence please: ");
//             string input = Console.ReadLine();
//
//             if (string.IsNullOrEmpty(input))
//             {
//                 Console.WriteLine("The input cannot be empty.");
//                 return;
//             }
//
//             string[] sentence = input.Split(' ');
//             Array.Reverse(sentence);
//             string result = string.Join(" ", sentence);
//
//             Console.WriteLine(result);
//         }
//     }
// }
