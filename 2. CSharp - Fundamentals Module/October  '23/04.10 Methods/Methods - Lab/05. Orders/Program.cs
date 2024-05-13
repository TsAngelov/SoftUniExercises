namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Sums(drink, count);
        }
        static void Sums(string drink, int count)
        {
            double sum = 0;
            switch (drink)
            {

                case "coffee":
                    sum += 1.5 * count;
                    break;
                case "water":
                    sum += 1 * count;
                    break;
                case "coke":
                    sum += 1.4 * count;
                    break;
                case "snacks":
                    sum += 2 * count;
                    break;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}