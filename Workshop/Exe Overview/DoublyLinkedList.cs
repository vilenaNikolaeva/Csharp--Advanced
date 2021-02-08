using System;

namespace Exe_Overview
{
    public class DoublyLinkedList
    {
        public ListNode head;
        public ListNode tail;
        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (this.Count==0)
            {
                this.head =this.tail= new ListNode(element);
              
            }
            else
            {
                ListNode newHead = new ListNode(element);
                newHead.NextNode = this.head;
                newHead.PreviousNode = newHead;
                this.head = newHead;
            }
            this.Count++;
        }

        public void AddLast(int element)
        {
            if (this.Count==0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newTail = new ListNode(element);
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }

        public int RemoveFirst()
        {
            if (this.Count==0)
            {
                throw new Exception("The list is empty!");
            }
           
            var firstElement = this.head.Value;
            this.head = this.head.NextNode;

            if (this.head!=null)
            {
                this.head.PreviousNode = null;
            }
            else
            {
                this.tail = null;
            }
            this.Count--;
            return firstElement;
        }

        public int RemoveLast()
        {
            if (this.Count==0)
            {
                throw new Exception("The list is empty!");
            }
            var lastElement = this.tail.Value;
            this.tail = this.tail.PreviousNode;
            if (this.tail!=null)
            {
                this.tail.NextNode = null;

            }
            else
            {
                this.head = null;
            }
           
            this.Count--;

            return lastElement;

        }
        public void Foreach(Action<int> action)
        {
            var node = this.head;
            while (node!=null)
            {
                action(node.Value);
                node = node.NextNode;
            }
        }
    }
}
