using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerInCSharp
{
    public class MathHelpers
    {

        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
        /// The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below the given limit.
        /// </summary>
        /// <param name="below"></param>
        public int SumOfMultiplesOfThreeOrFive(int below)
        {
            if (below < 1)
            {
                throw new ArgumentOutOfRangeException();
            };

            return Enumerable.Range(0, below)
                .Where(i => (i.MultipleOf(3) || i.MultipleOf(5)))
                .Sum();
        }

        public List<int> FibonacciNumbersLessThan(int limit)
        {
            if (limit < 0) { throw new ArgumentOutOfRangeException("limit", "too negative"); }

            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);

            for (int i = 2; true; i++)
            {
                int n = l[i - 1] + l[i - 2];
                if (n >= limit)
                {
                    break;
                }
                l.Add(n);
            }
            return l;
        }

        public int SumOfEvenFibonacciNumbers(int lowerThan)
        {
            if (lowerThan < 0) { throw new ArgumentOutOfRangeException(); }

            return FibonacciNumbersLessThan(lowerThan)
                    .Where(f => f.MultipleOf(2))
                    .Sum();
        }
    }
}
