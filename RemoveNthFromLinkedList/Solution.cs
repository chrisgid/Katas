using System.Collections.Generic;
using System.Linq;

// https://leetcode.com/problems/remove-nth-node-from-end-of-list

namespace RemoveNthFromLinkedList
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode current = head;
            var nodes = new List<ListNode>();

            while (current != null)
            {
                nodes.Add(current);
                current = current.next;
            }

            int removeIndex = nodes.Count - n;

            ListNode beforeRemove = nodes.ElementAtOrDefault(removeIndex - 1);
            ListNode afterRemove = nodes.ElementAtOrDefault(removeIndex + 1);

            if (beforeRemove == null) return afterRemove;

            beforeRemove.next = afterRemove;

            return head;
        }
    }
}
