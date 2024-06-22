//String / int count   // Името е променено защо ми се струва по-нормалоно
//Но съм оставил namespace, class name etc...


using System;
using System.Collections.Generic;

namespace Week.Task_for_my_week;

public class String_Manipulation
{
    public static void String_Manipulator()
    {
        Console.Write("Give me your data: ");
        string input  = Console.ReadLine();
        char[] symbols = input.ToCharArray();
        
        List<string> letters = new List<string>();
        List<int> numbers = new List<int>();

        foreach (char symbol in symbols)
        {
            if (Char.IsLetter(symbol)) {letters.Add(symbol.ToString());}
            if (Char.IsDigit(symbol)) {numbers.Add((int)Char.GetNumericValue(symbol));}
        }

        Dictionary<int, int> Dict_Number_Counting = new Dictionary<int, int>();
        Dictionary<string, int> Dict_Letter_Counting = new Dictionary<string, int>();
        
        foreach (int num in numbers)
        {
            if (Dict_Number_Counting.ContainsKey(num))
            {Dict_Number_Counting[num] += 1;}
            
            else {Dict_Number_Counting[num] = 1;}
        }

        foreach (string letter in letters)
        {
            if (Dict_Letter_Counting.ContainsKey(letter))
            {Dict_Letter_Counting[letter] += 1;}

            else {Dict_Letter_Counting[letter] = 1;}
        }
        
        Console.WriteLine("Letter counts: ");
        foreach (var kvp in Dict_Letter_Counting)
            
        {Console.WriteLine($"The letter {kvp.Key}, can be seen {kvp.Value} times.");}
        
        Console.WriteLine("Numbers count: ");
        foreach (var kvp in Dict_Number_Counting)
            
        {Console.WriteLine($"The number {kvp.Key} can be seen {kvp.Value} times.");}
        

    }
}