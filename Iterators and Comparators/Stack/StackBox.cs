using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class StackBox<T> : IEnumerable<T>
    {
        private List<T> elements;
        private int count=-1;
       
        public StackBox()
        {
            this.elements =new List<T>();
        }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                elements.Insert(++count, item);
            }
        }

        public void Pop()
        {
            if (count<0)
            {
                throw new InvalidOperationException("No elements!");
            }
            count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = count; i >=0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
