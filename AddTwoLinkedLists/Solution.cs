using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoLinkedLists
{
    public class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode rootOut = null;

            AddTwoNumbersCarry(l1, l2, rootOut, 0);

            return rootOut;
        }

        private static void AddTwoNumbersCarry(ListNode l1, ListNode l2, ListNode lout, int carry)
        {
            int addVal = l1.val + l2.val;
            int carryVal = addVal % 10;
            int newVal = addVal - carryVal;

            if (lout == null)
            {
                lout = new ListNode(newVal);
            }

            //if both l1 and l2 are null and carryVal==0 return

            //else AddTwoNumbersCarry(.....
        }
    }
}
