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
            return MathHelpers.FibonacciNumbersUpTo(4000000)
                    .Where(f => f.MultipleOf(2))
                    .Sum();
        }

        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// </summary>
        public static List<int> Problem3Example()
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
        public static int Problem4Example()
        {
            return MathHelpers.AllProductsOfXDigitNumbers(2)
                .Where(p => p.IsPalindromic())
                .Max();
        }

        /// <summary>
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public static int Problem4Solution()
        {
            return MathHelpers.AllProductsOfXDigitNumbers(3)
                .Where(p => p.IsPalindromic())
                .Max();
        }

        /// <summary>
        /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        /// </summary>
        public static int Problem5Example()
        {
            int upTo = 10;
            IEnumerable<int> factors = Enumerable.Range(1, upTo);
            int product = 0;

            do
            {
                product += upTo;
            } while (factors.Any(factor => !product.MultipleOf(factor)));

            return product;
        }

        /// <summary>
        /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        public static int Problem5Solution()
        {
            int upTo = 20;
            IEnumerable<int> factors = Enumerable.Range(1, upTo);
            int product = 0;

            do
            {
                product += upTo;
            } while (factors.Any(factor => !product.MultipleOf(factor)));

            return product;
        }

        /// <summary>
        /// The sum of the squares of the first ten natural numbers is 385
        /// The square of the sum of the first ten natural numbers is 3025
        /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        /// </summary>
        public static int Problem6Example()
        {
            int upTo = 10;

            int sum = Enumerable.Range(1, upTo).Sum();
            int squareOfSum = sum * sum;
           
            int sumOfSquares = Enumerable.Range(1, upTo)
                               .Select(i => i * i)
                               .Sum();

            return Math.Abs(sumOfSquares - squareOfSum);
        }

        /// <summary>
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// </summary>
        public static long Problem6Solution()
        {
            int upTo = 100;

            int sum = Enumerable.Range(1, upTo).Sum();
            int squareOfSum = sum * sum;

            int sumOfSquares = Enumerable.Range(1, upTo)
                               .Select(i => i * i)
                               .Sum();

            return Math.Abs(sumOfSquares - squareOfSum);
        }
    }
}
