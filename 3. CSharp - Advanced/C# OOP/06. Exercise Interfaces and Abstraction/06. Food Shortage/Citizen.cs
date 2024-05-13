using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Citizen : LivingBeing, IBirthable, IIdentifiable
    {
        public Citizen(string name, string birthday, int age, string id) : base(name, age)
        {
            Name = name;
            Birthday = birthday;
            Id = id;
            Age = age;
        }
        public string Birthday { get; set; }
        public string Id { get; set; }
        public override int Food { get; set; } = 0;

        public override void BuyFood()
        {
            Food += 10;
        }
    }
}
