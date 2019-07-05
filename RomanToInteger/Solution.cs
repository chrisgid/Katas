using System.Collections.Generic;

// https://leetcode.com/problems/roman-to-integer/

namespace RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int total = 0;
            int nextAdd = 0;
            char previous = '\0';

            foreach (var symbol in s)
            {
                if (Subractions.Contains(string.Concat(previous, symbol)))
                    total -= nextAdd;
                else
                    total += nextAdd;

                nextAdd = Symbols[symbol];
                previous = symbol;
            }

            total += nextAdd;

            return total;
        }


        public static Dictionary<char, int> Symbols = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static HashSet<string> Subractions = new HashSet<string>()
        {
            { "IV" }, { "IX" }, { "XL" }, { "XC" }, { "CD" }, { "CM" }
        };
    }
}
