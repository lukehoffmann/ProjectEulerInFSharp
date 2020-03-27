namespace ProjectEulerInCSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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
            var factors = Enumerable.Range(1, 10);
            return MathHelpers.SmallestMultipleOfAllFactors(factors);
        }

        /// <summary>
        /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        public static int Problem5Solution()
        {
            var factors = Enumerable.Range(1, 20);
            return MathHelpers.SmallestMultipleOfAllFactors(factors);
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

        /// <summary>
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        /// </summary>
        public static long Problem7Example()
        {
            return MathHelpers.NthPrime(6);
        }

        /// <summary>
        /// What is the 10001st prime number?
        /// </summary>
        public static long Problem7Solution()
        {
            return MathHelpers.NthPrime(10001);
        }

        public static string Problem8Data = "73167176531330624919225119674426574742355349194934" +
                                            "96983520312774506326239578318016984801869478851843" +
                                            "85861560789112949495459501737958331952853208805511" +
                                            "12540698747158523863050715693290963295227443043557" +
                                            "66896648950445244523161731856403098711121722383113" +
                                            "62229893423380308135336276614282806444486645238749" +
                                            "30358907296290491560440772390713810515859307960866" +
                                            "70172427121883998797908792274921901699720888093776" +
                                            "65727333001053367881220235421809751254540594752243" +
                                            "52584907711670556013604839586446706324415722155397" +
                                            "53697817977846174064955149290862569321978468622482" +
                                            "83972241375657056057490261407972968652414535100474" +
                                            "82166370484403199890008895243450658541227588666881" +
                                            "16427171479924442928230863465674813919123162824586" +
                                            "17866458359124566529476545682848912883142607690042" +
                                            "24219022671055626321111109370544217506941658960408" +
                                            "07198403850962455444362981230987879927244284909188" +
                                            "84580156166097919133875499200524063689912560717606" +
                                            "05886116467109405077541002256983155200055935729725" +
                                            "71636269561882670428252483600823257530420752963450";

        /// <summary>
        /// The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
        /// </summary>
        public static int Problem8Example()
        {
            string data = Problem8Data;
            int n = 4, l = data.Length;
            int max = 0;

            for (int i = 0; i + n <= l; i++)
            {
                int product = Enumerable.Range(i, n).Aggregate(1, (j, k) => j * data.DigitAtPosition(k));
                max = Math.Max(max, product);
            }

            return max;
        }

        /// <summary>
        /// Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
        /// </summary>
        public static long Problem8Solution()
        {
            string data = Problem8Data;
            int n = 13, l = data.Length;
            long max = 0;

            for (int i = 0; i + n <= l; i++)
            {
                long product = Enumerable.Range(i, n).Aggregate(1L, (j, k) => j * data.DigitAtPosition(k));
                max = Math.Max(max, product);
            }

            return max;
        }

        /// <summary>
        /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        /// Find the product abc.
        /// </summary>
        public static long Problem9Solution()
        {
            int a, b, c;

            for (a = 1; a < 998; ++a)
            {
                for (b = a; b < 998; ++b)
                {
                    for (c = b; c < 998; ++c)
                    {
                        if (a + b + c == 1000
                            && MathHelpers.IsPythagoreanTriplet(a, b, c))
                        {
                            return a * b * c;
                        }
                    }
                }
            }

            return 0;
        }

        public static long Problem10Test()
        {
            return MathHelpers.SumOfPrimesBelow(2000000 / 100);
        }

        /// <summary>
        /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        /// Find the sum of all the primes below two million.
        /// </summary>
        public static long Problem10Solution()
        {
            return MathHelpers.SumOfPrimesBelow(2000000);
        }

        private int[][] Problem11Data = new int[][]
        {
            new int[] { 08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08, },
            new int[] { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00, },
            new int[] { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65, },
            new int[] { 52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91, },
            new int[] { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80, },
            new int[] { 24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50, },
            new int[] { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70, },
            new int[] { 67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21, },
            new int[] { 24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72, },
            new int[] { 21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95, },
            new int[] { 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92, },
            new int[] { 16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57, },
            new int[] { 86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58, },
            new int[] { 19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40, },
            new int[] { 88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69, },
            new int[] { 04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36, },
            new int[] { 04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66, },
            new int[] { 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16, },
            new int[] { 20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54, },
            new int[] { 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48, },
        };


        public static long Problem11Solution()
        {
            // In the 20×20 grid below, four numbers along a diagonal line have been marked in red.
            // The product of these numbers is 26 × 63 × 78 × 14 = 1788696.
            // What is the greatest product of four adjacent numbers in the same direction(up,
            // down, left, right, or diagonally) in the 20×20 grid ?

            throw new NotImplementedException();
        }

    }
}
