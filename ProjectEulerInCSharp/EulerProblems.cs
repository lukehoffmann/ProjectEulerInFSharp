using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerInCSharp
{
    public class EulerProblems
    {
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
        /// The sum of these multiples is 23.
        /// </summary>
        public static int Problem1Example()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
            //The sum of these multiples is 23.
            return Enumerable.Range(0, 10)
                .Where(i => (i.MultipleOf(3) || i.MultipleOf(5)))
                .Sum();
        }

        /// <summary>
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public static int Problem1Solution()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
            //The sum of these multiples is 23.
            return Enumerable.Range(0, 1000)
                .Where(i => (i.MultipleOf(3) || i.MultipleOf(5)))
                .Sum();
        }

        /// <summary>
        /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        /// </summary>
        public static int Problem2Solution()
        {
            return MathHelpers.FibonacciNumbersLessThan(4000000)
                    .Where(f => f.MultipleOf(2))
                    .Sum();
        }

        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// </summary>
        public static List<long> Problem3Example()
        {
            return MathHelpers.PrimeFactorsOf(13195).ToList();
        }

        /// <summary>
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public static long Problem3Solution()
        {
            return MathHelpers.PrimeFactorsOf(600851475143).Max();
        }

        /// <summary>
        /// A palindromic number reads the same both ways. 
        /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// </summary>
        public static long Problem4Example()
        {
            return MathHelpers.ProductsOfXDigitNumbers(2)
                .Where(p => p.IsPalindromic())
                .Max();
        }

        /// <summary>
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public static long Problem4Solution()
        {
            return MathHelpers.ProductsOfXDigitNumbers(3)
                .Where(p => p.IsPalindromic())
                .Max();
        }
    }
}
