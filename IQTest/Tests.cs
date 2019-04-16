using NUnit.Framework;
using System;

namespace IQTest
{
    [TestFixture]
    public class IQTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, Solution.Test("2 4 7 8 10"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, Solution.Test("1 2 2"));
        }
    }
}