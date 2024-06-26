//Pu 2019 v1 Suns


namespace Week.Task_for_my_week;

public class Suns_distance
{
    public static void Suns_data()
    {

        int limit = 2000;
        int number_of_suns = 0;

        List<string> stars_name_number = new List<string>(); // <= 20 symbols
        List<decimal> stars_distance = new List<decimal>();  // > 0
        List<byte> stars_class = new List<byte>();  // 1,2,3,4,5,6,7,8,9
        List<decimal> stars_mass = new List<decimal>();  // > 0 in sun mas
        List<string> stars_constellation = new List<string>(); // <= 30 symbols

        while (number_of_suns < limit)
        {
            Console.Write("Do you want to add a star? Yes/No (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            if (answer is "y" or "yes")
            {
                Console.Write("Give me star name/number <= 20 symbols: ");
                string star_name_code = Console.ReadLine();
                
                if (star_name_code.Length <= 0 || star_name_code.Length > 20) 
                {Console.WriteLine("Invalid name/code..."); continue;}
                stars_name_number.Add(star_name_code);
                
                Console.Write("Whats you star distance from our Sun? in light years: ");
                
                try
                {
                    decimal lyDistance = decimal.Parse(Console.ReadLine());
                    if (lyDistance <= 0)
                    {Console.WriteLine("Distance must be grater than zero '0' "); continue;}
                    
                    stars_distance.Add(lyDistance);
                }
                catch (Exception e)
                {Console.WriteLine("Your answer is nod valid. " + e.Message) ;continue;}
                
                Console.Write("\n1- hyper giant" +
                              "\n2- super giant" +
                              "\n3- bright giant" +
                              "\n4- giant" +
                              "\n5- sub giant" +
                              "\n6- dwarf" +
                              "\n7- sub dwarf" +
                              "\n8- red dwarf" +
                              "\n9- brown dwarf\n What clas is your star: ");

                try
                {
                    byte star_class = byte.Parse(Console.ReadLine());
                    if (star_class >= 10 || star_class < 1 ) {Console.WriteLine("Invalid answer"); continue;}
                    
                    stars_class.Add(star_class);
                }
                
                catch (Exception e)
                {
                    Console.WriteLine("Invalid answer" + e.Message);
                    continue;
                }
                
                Console.Write("How fat is your star? (in sm): ");

                try
                {
                    decimal star_sun_mass = decimal.Parse(Console.ReadLine());
                    if (star_sun_mass <= 0) {Console.WriteLine("Invalid answer <0"); continue;}
                    stars_mass.Add(star_sun_mass);
                }
                catch (Exception e)
                {Console.WriteLine("Your answer is invalid " + e.Message );}
                
                Console.Write("Give me your star constellation <= 30: ");
                string constellation = Console.ReadLine();
                
                if (constellation.Length > 30) {Console.WriteLine("Invalid answer >30"); continue;}
                stars_constellation.Add(constellation);
                Console.WriteLine("Congrats you add your star successfully");
                number_of_suns += 1;
            }
            

            if (answer is "n" or "no")
            {
                Console.Write("Do you want to see our data? (Print): Y/N Yes/No ");
                string print_answer = Console.ReadLine().ToLower();

                if (print_answer is "n" or "no")
                {Console.WriteLine("Have a good day"); break;}

                if (print_answer is "y" or "yes")
                {
                    var combined_list = stars_name_number.Select((element, index) => new 
                    {
                        name_code = element,
                        stars_distance = stars_distance[index],
                        stars_class = stars_class[index],
                        stars_mass = stars_mass[index],
                        stars_constellation = stars_constellation[index]
                    }).ToList();
                    
                    var average_mass_by_constellation = combined_list
                        .GroupBy(star => star.stars_constellation)
                        .Select(group => new
                        {
                            Constellation = group.Key,
                            AverageMass = group.Average(star => star.stars_mass)
                        })
                        .ToList();
                    
                    var sorted_by_dsitance = combined_list.OrderBy(distance => distance.stars_distance).ToList();
                    var sorted_by_constellation = combined_list.OrderBy(constellation => constellation.stars_constellation).ThenBy(mass => stars_mass).ToList();

                    foreach (var items in sorted_by_dsitance)
                    {
                        Console.WriteLine($"{items.name_code}," +
                                          $" {items.stars_distance} (light years)," +
                                          $" {items.stars_class} class," +
                                          $" {items.stars_mass} (times sun mass)," +
                                          $" from {items.stars_constellation}\n");
                    }
                    
                    foreach (var items in sorted_by_constellation)
                    {
                        Console.WriteLine($"{items.name_code}," +
                                          $" {items.stars_distance} (light years)," +
                                          $" {items.stars_class} class," +
                                          $" {items.stars_mass} (times sun mass)," +
                                          $" from {items.stars_constellation}\n");
                    }
                    
                    foreach (var items in average_mass_by_constellation)
                    {
                        Console.WriteLine($"The Constellation {items.Constellation} is with {items.AverageMass} average mass");
                    }
                    
                    
                }
            }
        }
    }
}