namespace _03._Pirates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();
            string input;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] arg = input.Split("||");
                string cityName = arg[0];
                int population = int.Parse(arg[1]);
                int gold = int.Parse(arg[2]);
                if (cities.ContainsKey(cityName))
                {
                    cities[cityName].Population += population;
                    cities[cityName].Gold += gold;
                }
                else
                    cities.Add(cityName, new City(population, gold));
            }
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arg = input.Split("=>");
                string command = arg[0];
                string town = arg[1];
                if (command == "Plunder")
                {
                    int people = int.Parse(arg[2]);
                    int gold = int.Parse(arg[3]);
                    cities[town].Population -= people;
                    cities[town].Gold -= gold;
                    if (cities[town].Population <= 0 || cities[town].Gold <= 0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                    else
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                }
                else
                {
                    int gold = int.Parse(arg[2]);
                    if (gold < 0)
                        Console.WriteLine("Gold added cannot be a negative number!");
                    else
                    {
                        cities[town].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
                    }
                }
            }s
            foreach (var city in City)
            {

            }

        }
    }
    public class City
    {
        public City(int population, int gold)
        {
            Population = population;
            Gold = gold;
        }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
