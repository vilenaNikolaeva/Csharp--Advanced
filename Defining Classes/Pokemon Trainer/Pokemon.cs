using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Trainer
{
    class Pokemon
    {
        public string Name { get; set; }
        public string ELement { get; set; }
        public int Health { get; set; }


        public Pokemon(string name,string element,int health)
        {
            this.Name = name;
            this.ELement = element;
            this.Health = health;
        }
    }
}
