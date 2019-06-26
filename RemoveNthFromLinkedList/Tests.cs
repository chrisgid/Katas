using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNthFromLinkedList
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void Test1()
        {
            var root1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };

            var solution = new Solution();

            solution.RemoveNthFromEnd(root1, 3);
        }
    }
}
