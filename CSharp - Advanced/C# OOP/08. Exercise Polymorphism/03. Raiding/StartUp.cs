using Raiding.Models;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> list = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
                switch (heroType) 
                {
                    case "Druid": list.Add(new Druid(heroName)); break;
                    case "Paladin": list.Add(new Paladin(heroName)); break;
                    case "Rogue": list.Add(new Rogue(heroName)); break;
                    case "Warrior": list.Add(new Warrior(heroName)); break;
                    default: Console.WriteLine("Invalid hero!"); i--; continue;
                }
            }

            int bossHP = int.Parse(Console.ReadLine());
            int sum = list.Sum(h => h.Power);

            list.ForEach(hero => Console.WriteLine(hero.CastAbility()));
            

            Console.WriteLine(sum >= bossHP ? "Victory!" : "Defeat...");
        }
    }
}
