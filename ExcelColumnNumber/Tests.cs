using NUnit.Framework;

namespace ExcelColumnNumber
{
    class Tests
    {
        Solution solution = new Solution();

        [Test]
        public void AIs1()
        {
            Assert.That(solution.TitleToNumber("A") == 1);
        }

        [Test]
        public void BIs2()
        {
            Assert.That(solution.TitleToNumber("B") == 2);
        }

        [Test]
        public void AAis27()
        {
            Assert.That(solution.TitleToNumber("AA") == 27);
        }
    }
}
