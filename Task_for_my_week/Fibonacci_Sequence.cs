// Fibonacci Sequence

using System;
using System.Collections.Generic;

namespace Week.Task_for_my_week;

public class Fibonacci
{
    public static void Fibonacci_Calculator()
    {
        Console.Write("Give me your number: ");
        int n = int.Parse(Console.ReadLine());
        
        

        static List<int> Calculator(int end_point)
        {
            
            List<int> return_list = new List<int>() {};
            
            if (end_point <= 0) 
                return return_list;
            
            if (end_point == 1)
            {
                return_list.Add(0); 
                return return_list;
            }
            
            return_list.Add(0); 
            return_list.Add(1); 
                
            
            int x = 0;
            int y = 1;
            
            for (int end = 2; end < end_point; end += 1)
            {
                int number_to_add = return_list[x] + return_list[y];
                return_list.Add(number_to_add);

                x += 1;
                y += 1;
                
            }
 
            
            return return_list;
        }


        List<int> result = Calculator(n);
        
        Console.Write("Your answer is: ");
        foreach (int item in result)
        { Console.Write($"{item}, "); }
    }
}