using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoLinkedLists
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void Test1()
        {
            var root1 = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                }
            };

            var root2 = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                }
            };


            var expected = new ListNode(7)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(8)
                }
            };

            var actual = Solution.AddTwoNumbers(root1, root2);

            Assert.That(AreSame(actual, expected));
        }

        /// <summary>
        /// Recursively compares ListNodes
        /// </summary>
        private bool AreSame(ListNode l1, ListNode l2)
        {
            if (l1.val == l2.val)
            {
                if (l1.next == null && l2.next == null)
                {
                    return true;
                }
                else if (l1.next != null && l2.next == null)
                {
                    return false;
                }
                else if (l1.next == null && l2.next != null)
                {
                    return false;
                }

                return AreSame(l1.next, l2.next);
            }
            else
            {
                return false;
            }
        }
    }
}
