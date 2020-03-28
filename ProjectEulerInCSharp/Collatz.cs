using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerInCSharp
{
    public class Collatz
    {
        // The following iterative sequence is defined for the set of positive integers:
        //
        //      n → n/2 (n is even)
        //      n → 3n + 1 (n is odd)
        //
        // Although it has not been proved yet (Collatz Problem), it is thought that all starting
        // numbers finish at 1.
        public static IEnumerable<int> Sequence(int n)
        {
            var rv = new List<int> {n};
            while (n > 1)
            {
                n = n % 2 == 0
                    ? n / 2
                    : 3 * n + 1;
                rv.Add(n);
            }
            return rv;
        }

        // Which starting number, under one million, produces the longest chain?
        //
        // NOTE: Once the chain starts the terms are allowed to go above one million.

    }
}
