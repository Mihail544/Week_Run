//Odd_Even

using System;
using System.Collections.Generic;

namespace Week.Task_for_my_week;
public class Odd_Even
{
    public static void Odd_Even_check() 
    {
        int number = 0;

        while (true)
        {
            Console.Write("Give me a number: ");
            string input = Console.ReadLine();

            try
            {
                number = int.Parse(input);
                break;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("I told you to give me a number but... " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Even I am not sure what's wrong this time: " + ex.Message);
            }
        }

        if (number % 2 == 0)
        { 
            Console.WriteLine($"Your number ({number}) is Even");
        }
        else
        {
            Console.WriteLine($"Your number ({number}) is Odd");
        }
    }
}