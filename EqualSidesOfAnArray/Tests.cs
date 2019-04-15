using NUnit.Framework; 
using System;

namespace EqualSidesOfAnArray
{
    [TestFixture]
    public class ValidateWordTest
    {
        [Test]
        public void GenericTest()
        {
            Assert.AreEqual(3, Solution.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
        }

        [Test]
        public void GenericTest2()
        {
            Assert.AreEqual(1, Solution.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
        }

        [Test]
        public void GenericTest3()
        {
            Assert.AreEqual(-1, Solution.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
        }

        [Test]
        public void GenericTest4()
        {
            Assert.AreEqual(3, Solution.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
        }
    }
}