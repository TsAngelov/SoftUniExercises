using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const double MouseWeightMultiplier = 0.1;
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override IReadOnlyCollection<Type> PreferredFood 
            => new List<Type> { typeof(Vegetable), typeof(Fruit)}.AsReadOnly();

        protected override double WeightMultiplier => MouseWeightMultiplier;

        public override string ProduceSound()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
