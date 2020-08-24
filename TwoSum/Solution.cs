namespace TwoSum
{

    // https://leetcode.com/problems/two-sum/

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var length = nums.Length;

            for (var i = 0; i < length - 1; i++)
            {
                for (var j = i + 1; j < length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }

            return new int[] { };
        }
    }
}
