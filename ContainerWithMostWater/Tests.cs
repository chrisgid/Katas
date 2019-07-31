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
        public void ComputeAreaTest()
        {
            var position1 = 1;
            var position2 = 8;
            var heights = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var expected = 49;

            int actual = solution.ComputeArea(heights, position1, position2);

            Assert.AreEqual(expected, actual);
        }

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

        [Test]
        public void ThreeLines()
        {
            int[] input = new int[] { 3, 2, 4 };
            int expected = 6;

            int actual = solution.MaxArea(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ThreeLines2()
        {
            int[] input = new int[] { 3, 2, 3 };
            int expected = 6;

            int actual = solution.MaxArea(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
