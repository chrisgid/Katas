using System.Collections.Generic;
using System.Linq;
using System.Text;

// https://leetcode.com/problems/sort-characters-by-frequency/

namespace SortCharactersByFrequency
{
    public class Solution
    {
        public string FrequencySort(string s)
        {
            if (s.Length == 0 || s.Length == 0)
            {
                return s;
            }

            var letterCounts = new Dictionary<char, int>();

            foreach(char c in s)
            {
                if (letterCounts.ContainsKey(c))
                {
                    letterCounts[c] += 1;
                }
                else
                {
                    letterCounts.Add(c, 1);
                }
            }

            var stringBuilder = new StringBuilder();

            foreach (KeyValuePair<char, int> charCount in letterCounts.OrderByDescending(m => m.Value))
            {
                stringBuilder.Append(charCount.Key, charCount.Value);
            }

            return stringBuilder.ToString();
        }
    }
}
