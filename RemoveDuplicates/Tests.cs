using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    [TestFixture]
    public class Tests
    {
        private readonly Solution _solution;

        public Tests()
        {
            _solution = new Solution();
        }

        [Test]
        public void Returns_length_2()
        {
            var input = new int[] { 1, 1, 2 };
            var expectedArray = new int[] { 1, 2 };
            var expectedLength = expectedArray.Length;

            var actualLength = _solution.RemoveDuplicates(input);

            Assert.AreEqual(expectedLength, actualLength);
            Assert.AreEqual(expectedArray, input.Take(expectedLength).ToArray());
        }

        [Test]
        public void Returns_length_5()
        {
            var input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var expectedArray = new int[] { 0, 1, 2, 3, 4 };
            var expectedLength = expectedArray.Length;

            var actualLength = _solution.RemoveDuplicates(input);

            Assert.AreEqual(expectedLength, actualLength);
            Assert.AreEqual(expectedArray, input.Take(expectedLength).ToArray());
        }
    }
}
