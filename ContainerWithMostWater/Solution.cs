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
            if (height.Length <= 2) return height.Min();

            int tallestPostion;
            int secondTallestPosition;

            if (height[0] > height[1])
            {
                tallestPostion = 0;
                secondTallestPosition = 1;
            }
            else
            {
                tallestPostion = 1;
                secondTallestPosition = 0;
            }

            for (int i = 2; i < height.Length; i++)
            {
                if (height[i] > height[secondTallestPosition])
                {
                    if (height[i] > height[tallestPostion])
                    {
                        secondTallestPosition = tallestPostion;
                        tallestPostion = i;
                    }
                    else
                    {
                        secondTallestPosition = i;
                    }
                }
            }

            return ComputeArea(height, tallestPostion, secondTallestPosition);
        }

        public int ComputeArea(int[] heights, int position1, int position2)
        {
            int width = position1 - position2;
            if (width < 0) width = -width;

            int height = heights[position1] <= heights[position2] ? heights[position1] : heights[position2];

            return width * height;
        }
    }
}
