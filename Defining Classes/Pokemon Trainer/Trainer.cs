using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Trainer
{
    class Trainer
    {
        public string Name { get; set; }
        public int NumberBadges { get; set; }
        public List<Pokemon> PokemonCollection { get; set; }

        public Trainer(string name)
        {
            this.Name =name;
            this.NumberBadges = 0;
            this.PokemonCollection = new List<Pokemon>() ;
        }
    }
}
