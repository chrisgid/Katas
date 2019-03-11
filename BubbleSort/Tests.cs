using System;
using NUnit.Framework;

namespace BubbleSort
{
    [TestFixture]
    public class Tests
    {
        Solution solution = new Solution();

        [Test]
        public void Test1()
        {
            int[] test = new int[] { 8, 2, 4, 2, 9, 6, 1 };

            int[] expected = new int[test.Length];
            test.CopyTo(expected, 0);
            Array.Sort(expected);

            solution.BubbleSort(test);

            Assert.AreEqual(expected, test);
        }
    }
}
