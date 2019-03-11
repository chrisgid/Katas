using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.codewars.com/kata/564057bc348c7200bd0000ff/train/csharp

namespace ARuleOfDivisibilityBy13
{
    public class Thirteen
    {
        public static long Thirt(long n)
        {
            long total = 0;

            for (int i = 0; i < Math.Floor(Math.Log10(n) + 1); i++)
                total += (long)(n / Math.Pow(10, i) % 10) * (long)(Math.Pow(10, i) % 13);

            return total != n ? Thirt(total) : n;
        }

        // Expanded and more readable version of above method
        public static long ThirtExpanded(long n)
        {
            long total = 0;
            int nLength = (int)Math.Floor(Math.Log10(n) + 1); // Length in digits of n, same as n.ToString().Length;

            for (int i = 0; i < nLength; i++)
            {
                double tenPow = Math.Pow(10, i);
                long digit = (long)(n / tenPow % 10); // Gets the i-th digit of n (right to left)
                long remainder = (long)(tenPow % 13); // Loops through these numbers 1, 10, 9, 12, 3, 4
                total += digit * remainder;
            }

            if (total != n)
                return Thirt(total);
            else
                return n;
        }
    }
}
