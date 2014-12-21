using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerInCSharp
{
    public static class Extensions
    {

        public static bool MultipleOf(this int n, int factor)
        {
            return n % factor == 0;
        }

        public static bool MultipleOf(this long n, long factor)
        {
            //System.Diagnostics.Debug.WriteLine(n + " / " + factor);
            return n % factor == 0;
        }

        public static bool IsPalindromic(this int n)
        {
            return n.ToString().Reverse() == n.ToString();
        }

        public static bool IsPrime(this int n)
        {
            return MathHelpers.FactorsOf(n).Count() == 0;
        }

        public static string Reverse(this string s)
        {
            if (s == null) return null;

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
