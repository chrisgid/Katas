using NUnit.Framework;

namespace SortCharactersByFrequency
{
    public class Tests
    {
        Solution solution;

        [SetUp]
        public void SetUp()
        {
            solution = new Solution();
        }

        [Test]
        public void S()
        {
            string stringIn = "s";
            string stringOut = solution.FrequencySort(stringIn);
            string expected = "s";
            Assert.AreEqual(expected, stringOut);
        }

        [Test]
        public void Tr()
        {
            string stringIn = "tr";
            string stringOut = solution.FrequencySort(stringIn);
            string expected = "tr";
            Assert.AreEqual(expected, stringOut);
        }

        [Test]
        public void Tree()
        {
            string stringIn = "tree";
            string stringOut = solution.FrequencySort(stringIn);
            Assert.That(stringOut == "eetr" || stringOut == "eert");
        }

        [Test]
        public void Cccaaa()
        {
            string stringIn = "cccaaa";
            string stringOut = solution.FrequencySort(stringIn);
            Assert.That(stringOut == "cccaaa" || stringOut == "aaaccc");
        }

        [Test]
        public void Aabb()
        {
            string stringIn = "Aabb";
            string stringOut = solution.FrequencySort(stringIn);
            Assert.That(stringOut == "bbAa" || stringOut == "bbAa");
        }
    }
}
