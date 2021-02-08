using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListIterator<T> : IEnumerable<T>
    {
        private List<T> elements;
        private int count;

        public ListIterator(params  T[] element)
        {
            this.elements = new List<T>(element);
        }
        public bool Move()
        {
            if (count < elements.Count - 1)
            {
                count++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            return count + 1 < elements.Count;
        }
        public void Print()
        {
            if (elements.Count==0)
            {
                throw new InvalidOperationException("Invalid operation!");
            }

            Console.WriteLine(elements[count]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
