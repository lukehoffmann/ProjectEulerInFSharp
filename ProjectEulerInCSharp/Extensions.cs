using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerInCSharp
{
    static class Extensions
    {

        public static bool MultipleOf(this int n, int factor)
        {
            return n % factor == 0;
        }

        public static bool MultipleOf(this long n, long factor)
        {
            System.Diagnostics.Debug.WriteLine(n + " / " + factor);
            return n % factor == 0;
        }

        public static bool IsPrime(this int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n.MultipleOf(i))
                {
                    return false;
                }
            }
            return true;
        }


        public static bool IsPrime(this long n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n.MultipleOf(i))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
