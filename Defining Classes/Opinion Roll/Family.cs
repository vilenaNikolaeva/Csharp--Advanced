using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opinion_Roll
{
    class Family
    {
        public List<Person> OlderPerson { get; set; }


        public Family()
        {
            this.OlderPerson = new List<Person>();
        }

        public void AddMember(Person member)
        {
            OlderPerson.Add(member);
        }

        public Person GetOlderMember()
        {
            return this.OlderPerson.OrderByDescending(p => p.Age).First();
        }

        public List<Person> GetPeopleAbove30()
        {
            return this.OlderPerson
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();
        }

    }
}
