using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Swap_Method_Integers
{
     public class Box<T>
    {
       
        public List<T> Data { get; set; }

        public Box(List<T> value)
        {
            this.Data = value;  
        }
        public void Add(T element)
        {
            this.Data.Add(element);
        }

        public void Swipe(List<T> data, int first, int second)
        {
            var current = data[first];
            data[first] = data[second];
            data[second] = current;
        }

        public override string ToString()
        {
            return $"{this.Data.GetType().FullName}{this.Data}";
        }
    }
}
