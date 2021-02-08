using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guilds
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Players> Data { get; set; }

        public Guilds(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Data = new List<Players>();
        }
        public void AddPlayer(Players player)
        {
            if (this.Data.Count+1<this.Capacity)
            {
                this.Data.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            Players player = this.Data
                 .FirstOrDefault(n => n.Name == name);

            if (player!=null)
            {
                this.Data.Remove(player);
                return true;
            }
            return false;
        }

        public Players PromotePlayer(string name)
        {
            Players player = this.Data
                 .Where(n => n.Name == name)
                 .FirstOrDefault(n=>n.Rank!=default);
            if (player==default)
            {
                player.Rank = "Member";
            }
            return player;
        }

        public Players DemotePlayer(string name)
        {
            Players player = this.Data
                 .Where(n => n.Name == name)
                 .FirstOrDefault(n => n.Rank != default);

            if (player!=default)
            {
                player.Rank = default;
            }
            return player;
        }

        public Players[] KickPlayersByClass(string clasS)
        {
            Players[] playersToDelate = this.Data
                .Where(n => n.Class == clasS)
                .ToArray();
            Players[] playersToReturn = this.Data
                .Where(n => n.Class != clasS)
                .ToArray();

            foreach (var item in playersToDelate)
            {
                this.Data.Remove(item);
            }
            return playersToReturn;
        }
        public int Count()
        {
            var reuslt = this.Data.Count;
            return reuslt;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rabbits available at { this.Name}:");

            foreach (var rabbit in this.Data)
            {
                sb.AppendLine(rabbit.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
