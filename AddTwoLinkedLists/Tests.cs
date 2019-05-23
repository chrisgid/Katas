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
        public void LeetCodeExample()
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

            Assert.That(HaveSameVals(actual, expected));
        }

        [Test]
        public void AllZero()
        {
            var root1 = new ListNode(0);
            var root2 = new ListNode(0);
            var expected = new ListNode(0);

            var actual = Solution.AddTwoNumbers(root1, root2);

            Assert.That(HaveSameVals(actual, expected));
        }

        [Test]
        public void OneNull()
        {
            ListNode root1 = null;
            var root2 = new ListNode(1);
            var expected = new ListNode(1);

            var actual = Solution.AddTwoNumbers(root1, root2);

            Assert.That(HaveSameVals(actual, expected));
        }

        [Test]
        public void AllNines()
        {
            var root1 = new ListNode(9)
            {
                next = new ListNode(9)
                {
                    next = new ListNode(9)
                }
            };

            var root2 = new ListNode(9)
            {
                next = new ListNode(9)
                {
                    next = new ListNode(9)
                }
            };


            var expected = new ListNode(8)
            {
                next = new ListNode(9)
                {
                    next = new ListNode(9)
                    {
                        next = new ListNode(1)
                    }
                }
            };

            var actual = Solution.AddTwoNumbers(root1, root2);

            Assert.That(HaveSameVals(actual, expected));
        }

        [Test]
        public void DifferentLengths()
        {
            var root1 = new ListNode(9);

            var root2 = new ListNode(9)
            {
                next = new ListNode(9)
                {
                    next = new ListNode(9)
                }
            };


            var expected = new ListNode(8)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(0)
                    {
                        next = new ListNode(1)
                    }
                }
            };

            var actual = Solution.AddTwoNumbers(root1, root2);

            Assert.That(HaveSameVals(actual, expected));
        }

        /// <summary>
        /// Recursively compares ListNodes
        /// </summary>
        private bool HaveSameVals(ListNode l1, ListNode l2)
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

                return HaveSameVals(l1.next, l2.next);
            }
            else
            {
                return false;
            }
        }
    }
}
