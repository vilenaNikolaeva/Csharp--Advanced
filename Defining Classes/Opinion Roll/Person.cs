using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opinion_Roll
{
    class Person
    {
        private string name;
        private int age;
        
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name}-{this.Age}";
        }
    }
}
