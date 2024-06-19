namespace Week.Task_for_my_week;

public class Prime
{
    public static void Prime_number()
    {
        bool Is_Prime = false;
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
        
        if (number < 0) {Console.WriteLine("You need to give positive number.");}
        else if (number == 1 || number == 2) {Console.WriteLine($"Your number ({number}) is Prime.");}
        
        else 
        {
            for (int num = number -1; num > 2; num-=1)
            {
                if (Is_Prime) {Console.WriteLine($"Your number {number} is Prime."); break;}
                if (number % num == 0) {Is_Prime = true;}
            }
            
            if (Is_Prime == false) {Console.WriteLine($"Your number is notPrime {number}");}
        }
    }
}

