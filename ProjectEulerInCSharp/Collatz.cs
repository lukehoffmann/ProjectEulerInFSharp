using System.Collections.Generic;

namespace ProjectEulerInCSharp
{
    public class Collatz
    {
        private readonly Dictionary<long, long> knownLengths = new Dictionary<long, long>();

        // The following iterative sequence is defined for the set of positive integers:
        //
        //      n → n/2 (n is even)
        //      n → 3n + 1 (n is odd)
        //
        // Although it has not been proved yet (Collatz Problem), it is thought that all starting
        // numbers finish at 1.
        public IEnumerable<long> Sequence(long n)
        {
            yield return n;
            while (n > 1)
                yield return n = Next(n);
        }

        public long SequenceLength(long n)
        {
            long count = 1;
            var item = n;
            while (item > 1)
            {
                if (knownLengths.ContainsKey(item))
                {
                    count += knownLengths[item];
                    break;
                }

                item = Next(item);
                count++;
            }

            knownLengths[n] = count;
            return count;
        }

        private static long Next(long n)
        {
            return n.IsEven()
                ? n / 2
                : 3 * n + 1;
        }

    }
}
