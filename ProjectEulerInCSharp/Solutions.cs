using System;
using System.Collections.Generic;
using System.Linq;
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
        public Int32 SumOfMultiplesOfThreeOrFive(Int32 below)
        {
            if (below < 1)
            {
                throw new ArgumentOutOfRangeException();
            };

            return Enumerable.Range(1, below - 1)
                .Where(i => (i % 3 == 0 || i % 5 == 0))
                .Sum();
        }
    }
}
