//Week.Task_for_my_week

using System;
using System.Collections.Generic;

public class Sum_of_Multiples
{ 
        public static void Sum_Multiples()
        {
                int result = 0;
                
                List<int> my_list = new List<int>();
                
                Console.Write("Give me your numebr: ");
                int number = int.Parse(Console.ReadLine());

                for (int num = 1; num <= number; num += 1)

                {
                        if (num % 3 == 0 || num % 5 == 0) {my_list.Add(num);} 
                        Console.WriteLine(num);
                }

                foreach (int num in my_list)
                {
                        result += num;

                }
                
                Console.WriteLine(result);
                
        }
}
