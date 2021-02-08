using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oldest_Family_Member
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

    }
}
