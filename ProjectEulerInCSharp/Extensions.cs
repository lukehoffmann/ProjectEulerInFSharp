using System;
using System.Linq;

namespace ProjectEulerInCSharp
{
    public static class Extensions
    {

        public static int DigitAtPosition(this string s, int position)
        {
            return int.Parse(s[position].ToString());
        }

        public static bool IsPalindromic(this int n)
        {
            var s1 = n.ToString();
            return s1 == s1.Reverse();
        }

        public static bool IsPrime(this int n)
        {
            if (n == 0 || n == 1)
                return false;

            return !MathHelpers.FactorsOf(n).Any();
        }

        public static bool MultipleOf(this int n, int factor)
        {
            return n % factor == 0;
        }

        public static bool MultipleOf(this long n, long factor)
        {
            return n % factor == 0;
        }

        public static string Reverse(this string s)
        {
            if (s == null) return null;

            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
