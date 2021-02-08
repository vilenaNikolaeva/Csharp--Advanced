using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Count_Method_Doubles
{
    public class Box<T> where T : IComparable
    {
        public List<T> Data { get; set; }

        public Box(List<T> data)
        {
            this.Data = data;
        }

        public double ComapreNumberInSequance(List<T> data, T number)
        {
            var count = 0;

            foreach (var item in data)
            {
                if (item.CompareTo(number)>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
