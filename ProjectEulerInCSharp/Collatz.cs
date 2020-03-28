using System.Collections.Generic;

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
            yield return n;
            while (n > 1)
            {
                yield return n =
                    n.IsEven()
                        ? n / 2
                        : 3 * n + 1;
            }
        }

        // Which starting number, under one million, produces the longest chain?
        //
        // NOTE: Once the chain starts the terms are allowed to go above one million.

    }
}
