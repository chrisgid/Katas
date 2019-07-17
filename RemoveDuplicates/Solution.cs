using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/remove-duplicates-from-sorted-array/

namespace RemoveDuplicates
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1) return nums.Length;
            /* Modify the sorted list IN PLACE to remove any duplicates
             * Return the length of the array with the duplicates removed
             * Anything in the array after the returned length can be ignored
             * 
             * E.g. [1,1,2] would be modified to [1,2,x] where x is not important
             * and a length of 2 is returned.
            */

            int frontIndex = 0;
            int runnerIndex = 1;
            int frontNum = nums[frontIndex];

            while (runnerIndex < nums.Length)
            {
                int nextNum = nums[runnerIndex];

                if (frontNum == nextNum)
                {
                    runnerIndex++;
                }
                else
                {
                    frontIndex++;
                    frontNum = nextNum;
                    nums[frontIndex] = frontNum;
                }
            }

            return frontIndex + 1;
        }
    }
}
