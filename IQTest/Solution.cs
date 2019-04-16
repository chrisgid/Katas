using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.codewars.com/kata/552c028c030765286c00007d/train/csharp

namespace IQTest
{
    public class Solution
    {
        public static int Test(string numbers)
        {
            string[] split = numbers.Split(' ');

            int[] nums = new int[split.Length];

            for (int i = 0; i < split.Length; i++)
            {
                nums[i] = int.Parse(split[i]);
            }

            bool firstEven = nums[0] % 2 == 0;
            bool secondEven = nums[1] % 2 == 0;
            bool thirdEven = nums[2] % 2 == 0;



            return 1;
        }
    }
}
