//Sorting an Array


using System;
using System.Collections.Generic;


namespace Week.Task_for_my_week;

public class Sorting_an_Array
{
    public static void Sort_Array()
    {

        string answer = "";
        Console.Write("Give me your array of numbers: ");
        string numbers = Console.ReadLine();
        
        int[] split_numbers = numbers.Split(' ').Select(int.Parse).ToArray();
        Array.Sort(split_numbers);

        answer = string.Join(" ", split_numbers);
        
        Console.Write($"Your sorted answer is: {answer}");


    }
}