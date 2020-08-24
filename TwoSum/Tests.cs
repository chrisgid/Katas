using NUnit.Framework;

namespace TwoSum
{
    public class Tests
    {
        [TestCase(new [] {2, 7, 11, 15}, 9,  new [] {0, 1})]
        [TestCase(new [] {2, 7, 11, 15}, 13, new [] {0, 2})]
        [TestCase(new [] {2, 7, 11, 15}, 17, new [] {0, 3})]
        [TestCase(new [] {2, 7, 11, 15}, 18, new [] {1, 2})]
        [TestCase(new [] {2, 7, 11, 15}, 22, new [] {1, 3})]
        [TestCase(new [] {2, 7, 11, 15}, 26, new [] {2, 3})]
        public void TestCase1(int[] nums, int target, int[] expected)
        {
            // Arrange
            var solution = new Solution();
            
            // Act
            var actual = solution.TwoSum(nums, target);

            // Assert
            Assert.Contains(expected[0], actual);
            Assert.Contains(expected[1], actual);
        }
    }
}
