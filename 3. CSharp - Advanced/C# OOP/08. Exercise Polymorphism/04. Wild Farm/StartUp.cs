using System.Threading.Channels;
using WildFarm.Models;
using WildFarm.Models.Animals;
using WildFarm.Models.Animals.Birds;
using WildFarm.Models.Animals.Mammals;
using WildFarm.Models.Foods;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalInfo = input.Split();
                string[] foodInfo = Console.ReadLine().Split();

                Animal animal = default;
                animal = animalInfo[0] switch
                {
                    "Hen" => new Hen(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3])),
                    "Owl" => new Owl(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3])),
                    "Mouse" => new Mouse(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]),
                    "Cat" => new Cat(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]),
                    "Dog" => new Dog(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]),
                    "Tiger" => new Tiger(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4])
                };
                animals.Add(animal);

                Food food = default;
                food = foodInfo[0] switch
                {
                    "Fruit" => new Fruit(int.Parse(foodInfo[1])),
                    "Meat" => new Meat(int.Parse(foodInfo[1])),
                    "Seeds" => new Seeds(int.Parse(foodInfo[1])),
                    "Vegetable" => new Vegetable(int.Parse(foodInfo[1]))
                };

                Console.WriteLine(animal.ProduceSound()); 
                try
                {
                    animal.Eat(food);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            animals.ForEach(animal => Console.WriteLine(animal));

        }
    }
}
