using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PokemonTrainer
{
    public class PokemonTrainer
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var trainers = new HashSet<Trainer>();

            while (input != "Tournament")
            {
                var inputArgs = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var player = inputArgs[0];
                var pokemonName = inputArgs[1];
                var element = inputArgs[2];
                var health = double.Parse(inputArgs[3]);

                var pokemon = new Pokemon(pokemonName, element, health);

                if (trainers.All(x => x.Name != player))
                {
                    var trainer = new Trainer(player, new List<Pokemon>());
                    trainer.Pokemons.Add(pokemon);

                    trainers.Add(trainer);
                }
                else
                {
                    trainers.FirstOrDefault(x => x.Name == player).Pokemons.Add(pokemon);
                }
                input = Console.ReadLine();
            }

            var commands = Console.ReadLine();

            while (commands != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == commands))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            trainer.Pokemons[i].Health -= 10;

                            if (trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }

                commands = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count(x => x.Health > 0)}");
            }
            ;
        }
    }
}