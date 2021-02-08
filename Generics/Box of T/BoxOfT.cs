using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Box_of_T
{
    public class BoxOfT<T>
    {
        public Stack<T> data;
        public int Count { 
            get
            {
                return this.data.Count;
            } }
        public BoxOfT()
        {
            this.data = new Stack<T>();
        }
        public void Add(T item)
        {
          this.data.Push(item);
        }
        public T Remove()
        {
            return this.data.Pop();
        }
    }
}
