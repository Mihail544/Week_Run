//Sum_of_Multiples

using System;
using System.Collections.Generic;

namespace Week.Task_for_my_week;
public class Sum_of_Multiples
{ 
        public static void Sum_Multiples()
        {
                int result = 0;
                
                List<int> my_List = new List<int>();
                
                Console.Write("Give me your number: ");
                int number = int.Parse(Console.ReadLine());

                for (int num = 1; num < number; num += 1)

                {
                        if (num % 3 == 0 || num % 5 == 0) {my_List.Add(num);} 
                }

                foreach (int num in my_List) {result += num; }
                
                Console.WriteLine($"Your final result = {result}");
                
        }
}
