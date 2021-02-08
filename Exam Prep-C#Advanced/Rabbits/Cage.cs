using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
     public class Cage
    {
        private  readonly List<RabbitStore> data;
        public string Name { get; set; }
        public int Capacity { get; set; }

        public List<RabbitStore> Data { get; set; }

        private Cage()
        {
            this.data = new List<RabbitStore>();
        }
        public Cage(string name, int capacity)
            :this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }
        public void Add(RabbitStore rabbit)
        {
            if (this.data.Count+1<-this.Capacity)
            {
                data.Add(rabbit);
            }
        }
        public bool RemoveRabbit(string name)
        {
            RabbitStore rabbit = this.data
                .FirstOrDefault(n => n.Name == name);

            if (rabbit!=null)
            {
                this.data.Remove(rabbit);
                return true;
            }
            return false;
        }
        public void RabbitSpecies(string species)
        {
            this.data.RemoveAll(s => s.Species == species) ;
        }
        public RabbitStore SellRabbit(string name)
        {
            RabbitStore rabbit = this.data
                .FirstOrDefault(n => n.Name == name);
            if (rabbit!=null)
            {
                rabbit.Available = false;
            }
            return rabbit;
        }
        public RabbitStore[] SellRabbitsBySpecies(string species)
        {
            RabbitStore[] rabbits = this.data
                .Where(s => s.Species == species)
                .ToArray();

            foreach (var item in rabbits)
            {
                item.Available = false;
            }
            return rabbits;
        }
        public int Count()
        {
            var result = this.data.Count;

            return result;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rabbits available at { this.Name}:");

            foreach (var rabbit in this.data.Where(r=>r.Available))
            {
                sb.AppendLine(rabbit.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
