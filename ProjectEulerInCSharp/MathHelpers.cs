﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerInCSharp
{
    public static class MathHelpers
    {
        /// <summary>
        /// Unordered factors of the given number, including one and the number itself.
        /// </summary>
        public static List<long> FactorsOf(long n)
        {
            var factors = new HashSet<long>();
            var limit = (long)Math.Sqrt(n) + 1;

            for (var i = 1; i <= limit; i++)
            {
                if (!n.IsMultipleOf(i)) continue;
                factors.Add(i);
                factors.Add(n / i);
            }
            return factors.ToList();
        }

        /// <summary>
        ///Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
        ///By starting with 1 and 2, the first 10 terms will be:
        ///1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        ///Return a list of all Fibonacci terms less that the given limit.
        /// </summary>
        /// <returns>An ordered collection containing part of the Fibonacci sequence.</returns>
        public static IEnumerable<int> FibonacciNumbersUpTo(int limit)
        {
            if (limit < 0) { throw new ArgumentOutOfRangeException(nameof(limit), "too negative"); }

            int a;
            int b;
            yield return a = 1;
            yield return b = 2;
            do
            {
                var sum = a + b;
                a = b;
                yield return b = sum;

            } while (b <= limit);
        }

        /// <summary>
        /// An unordered list containing the number's factors that are prime numbers.
        /// </summary>
        public static IEnumerable<long> PrimeFactorsOf(long n)
        {
            return FactorsOf(n)
                .Where(f => f.IsPrime());
        }

        /// <summary>
        /// The nth prime number, counting up from 2.
        /// </summary>
         public static long NthPrime(int n)
         {
            var nPrimes = FirstNPrimes(n);

            return nPrimes[n - 1];
        }

        /// <summary>
        /// The first n prime numbers, counting up from 2.
        /// </summary>
        private static IList<int> FirstNPrimes(int n)
        {
            IList<int> primes = new List<int>();

            // It's quicker to repeat the 'primes below n' calculation
            // (of unknown length) than to calculate a known number of
            // primes once.

            // Take a guess at the highest prime required, then
            // increase the limit by an order of magnitude until
            // we have enough
            for (var max = n * 20; primes.Count < n; max *= 10)
            {
                primes = PrimesBelowN(max);
            }

            return primes.ToList().GetRange(0, n);
        }

        /// <summary>
        /// A Pythagorean triplet is a set of three natural numbers, a .lt. b .lt. c, for which,
        ///         a2 + b2 = c2
        /// </summary>
        public static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            return Math.Abs(Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) < 1.0e-6;
        }

        /// <summary>
        /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        /// </summary>
        public static long SumOfPrimesBelow(int below)
        {
            if (below < 2) throw new ArgumentException("too small for primes", nameof(below));

            return PrimesBelowN(below).Select(c => (long)c).Sum();
        }

        /// <summary>
        /// Get all primes smaller than N
        /// </summary>
        private static IList<int> PrimesBelowN(int n)
        {
            var range = Enumerable.Range(1, n - 1).ToList();

            // Make a lookup of all N integers, pretending they're all prime
            var isPrimes = range.ToDictionary(i => i, i => true);

            // Switch off 1 (1 is not prime)
            isPrimes[1] = false;

            // For every other number...
            for (var prime = 2; prime < n; ++prime)
            {
                // (unless we know it's not prime) ...
                if (!isPrimes[prime])
                    continue;

                // switch off all of it's multiples
                for (var multiple = 2 * prime; multiple < n; multiple += prime)
                    isPrimes[multiple] = false;
            }

            // Convert the lookup to a list
            return range
                .Where(c => isPrimes[c])
                .ToList();
        }

        public static IEnumerable<long> TriangleNumbers(long n)
        {
            var x = 0;
            for (var i = 1; i <= n; i++)
            {
                yield return x += i;
            }
        }

        public static long FirstTriangleNumberWhere(Func<long, bool> condition)
        {
            var i = 1;
            var t = 0 ;
            while (true)
            {
                t += i++;
                if (condition(t))
                    return t;
            }
        }
    }
}
