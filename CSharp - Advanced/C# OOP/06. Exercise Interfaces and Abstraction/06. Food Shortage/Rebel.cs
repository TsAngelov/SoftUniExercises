using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Rebel : LivingBeing, IBuyer
    {
        public Rebel(string name, string group, int age) : base(name, age)
        {
            Group = group;
        }
        public string Group {  get; set; }

        public override int Food { get; set; } = 0;

        public override void BuyFood()
        {
            Food += 5;
        }
    }
}
