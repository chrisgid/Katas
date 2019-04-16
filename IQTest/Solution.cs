using System.Collections.Generic;
using System.Linq;

// https://www.codewars.com/kata/552c028c030765286c00007d/train/csharp

namespace IQTest
{
    public class Solution
    {
        public static int Test(string numbers)
        {
            string[] split = numbers.Split(' ');

            int[] nums = new int[split.Length];

            // get int array
            for (int i = 0; i < split.Length; i++)
            {
                nums[i] = int.Parse(split[i]);
            }


            for (int i = 0; i < nums.Length; i += 3)
            {
                var three = nums.Skip(i).Take(3);
                if (!AllSameEvenness(three))
                {
                    return i + IndexDiffers(three) + 1;
                }
            }


            return 1;
        }

        private static bool AllSameEvenness(IEnumerable<int> ints)
        {
            return ints.All(i => i % 2 == 0) || ints.All(i => i % 2 == 1);
        }

        // Must be given 3 ints
        private static int IndexDiffers(IEnumerable<int> ints)
        {
            bool firstEven = ints.ElementAt(0) % 2 == 0;
            bool secondEven = ints.ElementAt(1) % 2 == 0;
            bool thirdEven = ints.ElementAt(2) % 2 == 0;

            if (firstEven == secondEven)
                return 2;
            else if (firstEven == thirdEven)
                return 1;
            else
                return 0;
        }
    }
}
