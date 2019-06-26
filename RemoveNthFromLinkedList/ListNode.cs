using System.Diagnostics;

namespace RemoveNthFromLinkedList
{
    [DebuggerDisplay("{val}")]
    public class ListNode
    {
        public ListNode(int x)
        {
            val = x;
        }

        public int val;
        public ListNode next;
    }
}
