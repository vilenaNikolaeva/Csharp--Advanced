using System;

namespace Overview
{
    class CustomList
    {
        private int[] data;
        private const int capacity = 2;

        public int[] Data { get; set; }
        public int Count { get; private set; }
        public int this[int index]
        {
            get
            {
                ValidateIndex(index);
                return this.data[index];
            }
            set 
            {
                ValidateIndex(index);
                this.data[index] = value;
            }
            
        }
        public CustomList()
        {
            this.data = new int[capacity];
        }
        public CustomList(int numCapacity)
        {
            this.data = new int[numCapacity];
        }

        private void Resize()
        {
            int[] copy = new int[this.data.Length * 2];
          
            for (int i = 0; i < this.data.Length; i++)
            {
                copy[i] = this.data[i];
            }
            this.data = copy;
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

        public void Remove( int index)
        {
            this.ValidateIndex(index);

            for (int i = index+1; i <this.Count; i++)
            {
                this.data[i - 1] = this.data[i];
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new Exception($"Index out of range.Valid position are from {0} to {Math.Max(0,this.Count-1)}.");
            }

        }
        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i]==element)
                {
                    return true;
                }
            }
            return false;
        }
        public void Swapint(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);
            var firstValue = this.data[secondIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = this.data[firstIndex];
        }
    }
}
