using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double DogWeightMultiplier = 0.4;
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        protected override IReadOnlyCollection<Type> PreferredFood 
            => new List<Type> { typeof(Meat) }.AsReadOnly();

        protected override double WeightMultiplier => DogWeightMultiplier;

        public override string ProduceSound()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
