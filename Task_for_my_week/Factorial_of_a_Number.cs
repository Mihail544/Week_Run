//Factorial of a Number

using System;
using System.Collections.Generic;


namespace Week.Task_for_my_week;

public class Factorial_of_a_Number
{
    public static void Factorial()
    {
        Console.Write("Give me your number: ");
        int number = int.Parse(Console.ReadLine());
        
        int total_sum = 1;

        for (int n = number; n > 0; n -= 1)
        { 
            total_sum *= n;
        }
        
        Console.WriteLine($"Your total sum is equal to {total_sum}");
    }
}