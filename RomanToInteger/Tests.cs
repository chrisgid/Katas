using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
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
        public void I_returns_1()
        {
            var input = "I";
            var expected = 1;

            var actual = _solution.RomanToInt(input);

            Assert.AreEqual(expected, actual);
        }

        public void D_returns_500()
        {
            var input = "D";
            var expected = 500;

            var actual = _solution.RomanToInt(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void III_returns_3()
        {
            var input = "III";
            var expected = 3;

            var actual = _solution.RomanToInt(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void XII_returns_12()
        {
            var input = "XII";
            var expected = 12;

            var actual = _solution.RomanToInt(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IV_returns_4()
        {
            var input = "IV";
            var expected = 4;

            var actual = _solution.RomanToInt(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IX_returns_9()
        {
            var input = "IX";
            var expected = 9;

            var actual = _solution.RomanToInt(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LVIII_returns_58()
        {
            var input = "LVIII";
            var expected = 58;

            var actual = _solution.RomanToInt(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MCMXCIV_returns_1994()
        {
            var input = "MCMXCIV";
            var expected = 1994;

            var actual = _solution.RomanToInt(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
