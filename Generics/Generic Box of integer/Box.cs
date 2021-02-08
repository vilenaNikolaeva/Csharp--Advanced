using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Box_of_integer
{
    public class Box<T>
    {
        private T item;

        public Box(T item)
        {
            this.item = item;
        }
        public override string ToString()
        {
            return $"{this.item.GetType().FullName}:{this.item}";
        }
    }
}
