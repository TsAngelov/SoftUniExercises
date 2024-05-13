using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Raiding
{
    public class HeroFactory
    {
        public BaseHero CreateHero(string type, string name)
        {
            return type switch
            {
                "Druid" => new Druid(name),
                "Paladin" => new Paladin(name),
                "Rogue" => new Rogue(name),
                "Warrior" => new Warrior(name),
                _ => throw new ArgumentException("Invalid hero!")
            };
        }
    }
}
