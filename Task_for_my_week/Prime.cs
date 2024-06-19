namespace Week.Task_for_my_week;

public class Prime
{
    public static void Prime_number()
    {
        Console.Write("Give me number: ");
        int input = int.Parse(Console.ReadLine());
        Console.Write($"if i am right your number is {input.GetType()} {input}");
    }
}