using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public string Name { get; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

        // Stores class types (of foods)
        protected abstract IReadOnlyCollection<Type> PreferredFood { get; }
        protected abstract double WeightMultiplier { get; }
        public abstract string ProduceSound();
        public void Eat(Food food)
        {
            // Checks if the given food type is contained in the PreferredFood List of Types
            if (!PreferredFood.Contains(food.GetType()))
            {
                throw new InvalidOperationException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }

            FoodEaten += food.Quantity;
            Weight += food.Quantity * WeightMultiplier;
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, ";
        }
    }
}
