namespace Exe_Overview
{
    public class ListNode
    {
        public int Value { get; set; }
        public ListNode NextNode { get; set; }
        public ListNode PreviousNode { get; set; }

        public ListNode(int value)
        {
            this.Value = value;
        }
        public override string ToString()
        {
            return this.Value.ToString();
        }

    }
}
