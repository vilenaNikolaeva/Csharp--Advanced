using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbits
{
    public class RabbitStore
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public bool Available { get; set; }

        public RabbitStore()
        {
            this.Available = true;
        }

        public RabbitStore(string name,string species)
            :this ()
        {
            this.Name = name;
            this.Species = species;
        }

        public override string ToString()
        {
            return $"Rabbit ({Species}): {Name}";
        }
    }
}
