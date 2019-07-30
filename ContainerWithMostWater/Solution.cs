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
        const int positionIndex = 0;
        const int heightIndex = 1;

        public int MaxArea(int[] height)
        {
            if (height.Length <= 2) return height.Min();

            // int[] { position, height }
            int[] tallest = new int[] { -1, -1 };
            int[] secondTallest = new int[] { -1, -1 };

            

            for (int i = 0; i < height.Length; i++)
            {

            }

            return height.Min();
        }

        private int ComputeArea(int[] one, int[] two)
        {
            int width = one[positionIndex] - two[positionIndex];
            if (width < 0) width = -width;

            int height = one[heightIndex] <= two[heightIndex] ? one[heightIndex] : two[heightIndex];

            return width * height;
        }
    }
}
