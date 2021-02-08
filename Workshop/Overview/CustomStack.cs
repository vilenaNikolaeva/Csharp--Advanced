using System;

namespace Overview
{
    class CustomStack
    {
        private int capacity;
        private int[] data;
        public int Count { get; private set; }


        public CustomStack(int capacity)
        {
            this.capacity = capacity;
            this.data = new int[capacity];
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

        public void Clear()
        {
            this.data = new int[this.capacity];
            this.Count = 0;
        }

        public void Foreach(Action<int> action)
        {
            for (int i =this.Count; i >=0; i--)
            {
                action(this.data[i]);
            }
        }
        public void Push(int number)
        {
            if (this.Count==this.data.Length)
            {
                this.Resize();
            }
            this.data[this.Count] = number;
            this.Count++;
        }

        public int Pop()
        {
            if (this.Count==0)
            {
                throw new Exception("Stack is empty");
            }
            var result = this.data[this.Count - 1];
            this.Count--;
            return result;
        }

        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new Exception("Stack is empty");
            }

            return this.data[this.Count - 1];
        }
    }

}
