using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerInCSharp
{
    static class Extensions
    {

        public static bool MultipleOf(this int i, int factor)
        {
            return i % factor == 0;
        }
    }
}
