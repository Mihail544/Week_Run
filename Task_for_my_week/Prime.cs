//Prime_numbers

using System;
using System.Collections.Generic;


namespace Week.Task_for_my_week
{
public class Prime
{
    public static void Prime_number()
    {
        bool Is_Prime = true;
        int number = 0;
        
        while (true)
        {
            Console.Write("Give me number: ");
            string input = Console.ReadLine();

            try
            {
                number = int.Parse(input);
                break;
            }
            
            catch (FormatException ex)
            {
                Console.WriteLine("Your number is not a number... i hope ");
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("I am not sure whats wrong..." + ex);
            }
            
        }
        
        if (number <= 0) {Console.WriteLine("You need to give > 0 number.");}
        else if (number == 1) {Console.WriteLine($"Your number ({number}) is notPrime.");}
        else if (number == 2) {Console.WriteLine($"Your number ({number}) is Prime.");}

        else
        {
            for (int x = 2;x <= Math.Sqrt(number);x += 1)
            {
                if (number % x == 0)
                    
                {Is_Prime = false; break;}
            }

        }
        
        if (Is_Prime)
        {Console.WriteLine($"Your number ({number}) is prime.");}
        else
        {Console.WriteLine($"Your number ({number}) is not prime.");}
        
    }
}
}
