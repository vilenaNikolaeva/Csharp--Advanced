using System;

namespace Implement_the_CutomList
{
    class CustomList
    {
        private int[] data;
        private const int capacity=2;

        public int[] Data { get; set; }
        public int Count { get; set; }

        public int this[int index]
        {
            get 
            {
                VAlidationIndex(index);
                return this.data[index];
            }
            set 
            {
                VAlidationIndex(index);
                this.data[index] = value;
            }
        }

        public CustomList()
        {
            this.Data = new int[capacity] ;
        }
        public CustomList(int capacity)
        {
            this.data = new int[capacity];
        }
        public void Add(int element)
        {
            if (this.Count==this.data.Length)
            {
                this.Resize();
            }
            this.data[this.Count] = element;
            this.Count++;
        }
        public void VAlidationIndex(int index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new Exception($"Index out of range.Valid position must be from {0} to {Math.Max(0, this.Count - 1)} ");
            }
        }

        public void Resize()
        {

            var copy = new int[capacity*2];
            for (int i = 0; i < this.data.Length-1; i++)
            {
                copy[i] = this.data[i];
            }
            this.data = copy;
        }
        public void Shrink()
        {
            var copy = new int[capacity / 2];
            for (int i = 0; i < this.data.Length; i++)
            {
                copy[i] = this.data[i];
            }
            this.data = copy;
        }
        public void Shift(int number)
        {
            for (int i =number+1; i < this.Count; i++)
            {
                this.data[i-1] = this.data[i];
            }
        }
        public void Foreach(Action<int> action)
        {
            for (int i = this.Count; i >=0; i--)
            {
                action(this.data[i]);
            }
        }
    }
}
