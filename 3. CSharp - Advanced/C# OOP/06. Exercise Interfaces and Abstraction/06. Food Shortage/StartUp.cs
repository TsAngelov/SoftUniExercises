namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<LivingBeing> livingBeings = new List<LivingBeing>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split();
                if (person.Length == 4)
                {
                    Citizen citizen = new Citizen(person[0], person[3], int.Parse(person[1]), person[2]);
                    livingBeings.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(person[0], person[2], int.Parse(person[1]));
                    livingBeings.Add(rebel);
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (livingBeings.Any(p => p.Name == input))
                {
                    (livingBeings.Find(p => p.Name == input)).BuyFood();
                }
            }

            Console.WriteLine(livingBeings.Sum(l => l.Food));
        }
    }
}