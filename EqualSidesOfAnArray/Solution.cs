using System.Linq;

// https://www.codewars.com/kata/5679aa472b8f57fb8c000047

namespace EqualSidesOfAnArray
{
    public class Solution
    {
        public static int FindEvenIndex(int[] arr)
        {
            int middle = 0;
            long sumLeft = 0;
            long sumRight = arr.Sum();

            for (int i = 0; i < arr.Length; i++)
            {
                sumLeft += middle;
                middle = arr[i];
                sumRight -= middle;

                if (sumLeft == sumRight) return i;
            }

            return -1;
        }
    }
}