using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerInCSharp
{
    public class Solutions
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

        public int FibonacciNumber(int n)
        {
            if (n < 0) { throw new ArgumentOutOfRangeException(); }
            if (n <= 3) { return n; }
            return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
        }

        public int SumOfEvenFibonacciNumbers(int lowerThan)
        {
            if (lowerThan < 0) { throw new ArgumentOutOfRangeException(); }
            int result = 0;
            for (int i = 1; true; i++)
            {
                int fibi = FibonacciNumber(i);
                if (fibi >= lowerThan) { break; }
                if (fibi.MultipleOf(2))
                {
                    result += fibi;
                }
            }
            return result;
        }
    }
}
