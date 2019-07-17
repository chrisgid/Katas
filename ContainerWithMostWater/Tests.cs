using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerWithMostWater
{
    [TestFixture]
    public class Tests
    {
        Solution solution = new Solution();

        [Test]
        public void TwoLinesOneZeroLength()
        {
            int[] input = new int[] { 0, 3 };
            int expected = 0;

            int actual = solution.MaxArea(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TwoLines()
        {
            int[] input = new int[] { 2, 3 };
            int expected = 2;

            int actual = solution.MaxArea(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ThreeLinesOneZeroLength()
        {
            int[] input = new int[] { 2, 3, 0 };
            int expected = 2;

            int actual = solution.MaxArea(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
