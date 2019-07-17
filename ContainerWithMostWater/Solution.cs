using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/container-with-most-water/

namespace ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            if (height.Length == 1) return 0;
            if (height.Length <= 2) return height.Min();

            

            for (int i = 0; i < height.Length; i++)
            {

            }

            return height.Min();
        }
    }
}
