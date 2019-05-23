using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/add-two-numbers/

namespace AddTwoLinkedLists
{
    public class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode rootOut = null;

            AddTwoNumbersCarry(l1, l2, ref rootOut, 0);

            return rootOut;
        }

        private static void AddTwoNumbersCarry(ListNode l1, ListNode l2, ref ListNode lout, int carry)
        {
            int addVal = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;

            int carryVal = addVal < 10 ? 0 : 1;

            lout = new ListNode(addVal % 10);
            
            if (l1?.next == null && l2?.next == null && carryVal == 0)
            {
                return;
            }
            else
            {
                AddTwoNumbersCarry(l1?.next, l2?.next, ref lout.next, carryVal);
            }
        }
    }
}
