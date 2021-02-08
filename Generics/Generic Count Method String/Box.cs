using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Count_Method_String
{
    public class Box<T> where T : IComparable
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

        public int CountGreaterElement(List<T>  data , T element)
        {
            int count = 0;
            foreach (var item in data)
            {
                if (element.CompareTo(item)<0)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
