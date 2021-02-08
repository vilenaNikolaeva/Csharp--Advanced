using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Players
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; } = "Trial";
        public string Description { get; set; } = "n/a";

      
        public Players(string name, string clasS)
        {
            this.Name = name;
            this.Class = clasS;
        }

        public override string ToString()
        {
            return $"Player {this.Name}{this.Class}\n" +
                   $"Rank: {this.Rank}\n" +
                   $"Description: {this.Description}";
        }
        
    }
}
