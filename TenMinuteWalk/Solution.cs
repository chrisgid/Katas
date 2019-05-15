using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenMinuteWalk
{
    public class Solution
    {
        public static bool IsValidWalk(string[] walk)
        {
            const int tenMinutes = 10;

            var position = new Position(0, 0);
            var totalDistance = 0;


            var validDistance = totalDistance == tenMinutes;
            var backToStart = position == new Position(0, 0);



            return validDistance && backToStart;
        }
    }

    public struct Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}