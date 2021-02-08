using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Trainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstCommand = string.Empty;
            List<Trainer> trainers = new List<Trainer>();

            while ((firstCommand=Console.ReadLine())!="Tournament")
            {

                var splitedInput = firstCommand
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var trainerName = splitedInput[0];
                var pokemonName = splitedInput[1];
                var element = splitedInput[2];
                var health =int.Parse(splitedInput[3]);

                if (!trainers.Any(t=>t.Name==trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }
                var trainer = trainers.First(t => t.Name == trainerName);

                trainer.PokemonCollection.Add(new Pokemon(pokemonName, element, health));
            }

            var badgets = string.Empty;

            while ((badgets=Console.ReadLine())!="End")
            {
                foreach ( var trainer in trainers)
                {
                    if (trainer.PokemonCollection.Any(p=>p.ELement==badgets))
                    {
                        trainer.NumberBadges++;
                    }
                    else 
                    {
                        foreach (var pokemon in trainer.PokemonCollection)
                        {
                            pokemon.Health -= 10;
                        }
                        trainer.PokemonCollection = trainer.PokemonCollection
                            .Where(p => p.Health > 0).ToList();
                    }
                }

            }

            foreach (var trainer in trainers.OrderByDescending(t=>t.NumberBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberBadges} {trainer.PokemonCollection.Count}");
            }
        }
    }
}
