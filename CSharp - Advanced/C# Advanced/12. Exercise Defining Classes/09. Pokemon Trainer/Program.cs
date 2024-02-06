using System.Collections.ObjectModel;

namespace PokemonTrainer;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Trainer> trainers = new();

        string input;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] info = input.Split();
            string trainerName = info[0],
                   pokemonName = info[1],
                   pokemonElement = info[2];
            int pokemonHealth = int.Parse(info[3]);

            if (trainers.ContainsKey(trainerName))
            {
                trainers[trainerName].Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }
            else
            {
                trainers.Add(trainerName, new Trainer(trainerName, pokemonName, pokemonElement, pokemonHealth));
            }
        }
        while ((input = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                bool containsElement = false;
                foreach (var pokemon in trainer.Value.Pokemons)
                {
                    if (pokemon.Element == input)
                    {
                        containsElement = true;
                        break;
                    }
                }

                if (containsElement)
                {
                    trainer.Value.BadgesCount++;
                }
                else
                {
                    foreach (var pokemon in trainer.Value.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                    trainer.Value.Pokemons = trainer.Value.Pokemons.Where(pokemon => pokemon.Health > 0).ToList();
                }
            }
        }

        trainers = trainers.OrderByDescending(trainer => trainer.Value.BadgesCount).ToDictionary(x => x.Key, x => x.Value);
        foreach (var trainer in trainers)
        {
            Console.WriteLine(trainer.Value);
        }
    }
}
