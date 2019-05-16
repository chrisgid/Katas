using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

// https://www.codewars.com/kata/take-a-ten-minute-walk/csharp

namespace TenMinuteWalk
{
    public class Solution
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10) return false;

            Point start = new Point(0, 0);
            var currentPosition = start;

            foreach (var direction in walk)
            {
                if (direction == "n")      start.X += 1;
                else if (direction == "e") start.Y += 1;
                else if (direction == "s") start.X -= 1;
                else if (direction == "w") start.Y -= 1;
            }
            
            return currentPosition == start;
        }
    }
}