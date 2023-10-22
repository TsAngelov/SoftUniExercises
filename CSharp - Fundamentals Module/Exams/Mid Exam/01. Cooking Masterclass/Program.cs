namespace _01._Cooking_Masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double flourCost = flourPrice * (students - (students / 5));
            double eggCost = eggPrice * 10 * students;
            double apronCost = apronPrice * (students + (Math.Ceiling(students * 0.2)));
            double price = flourCost + eggCost + apronCost;

            if (price <= budget)
                Console.WriteLine($"Items purchased for {price:f2}.$");
            else
                Console.WriteLine($"{price - budget:f2}$ more needed.");
        }
    }
}