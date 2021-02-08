using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private int[] data;
        public Lake(int[] stones)
        {
            this.data = stones;
        }

       
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i <data.Length; i+=2)
            {
                yield return data[i];
            }

            var reversed = data.Length % 2 == 0
                ? data.Length - 1 
                : data.Length - 2;

            for (int i = reversed; i>0; i-=2)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
