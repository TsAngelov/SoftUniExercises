using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer;

public class Trainer
{
    public string Name { get; set; }
    public int BadgesCount { get; set; }
    public List<Pokemon> Pokemons { get; set;}
    public Trainer()
    {
        BadgesCount = 0;
        Pokemons = new List<Pokemon>();
    }
    public Trainer(string name, string pokemonName, string element, int health) : this()
    {
        Name = name;
        Pokemons.Add(new Pokemon(pokemonName, element, health));
    }
    public override string ToString()
    {
        return $"{Name} {BadgesCount} {Pokemons.Count}";
    }
}
