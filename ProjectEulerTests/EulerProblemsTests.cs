using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerInCSharp;

namespace ProjectEulerTests
{
    [TestClass]
    public class EulerProblemsTests
    {

        [TestMethod]
        public void Problem1_ExampleTest()
        {
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3,
            // 5, 6 and 9. 
            // The sum of these multiples is 23.
            var result = EulerProblems.Problem1Example();
            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void Problem1_SolutionTest()
        {
            // Find the sum of all the multiples of 3 or 5 below 1000.
            var result = EulerProblems.Problem1Solution();

            Console.WriteLine($"Problem {1} = {result} ");
            Assert.AreEqual(233168, result);
        }

        [TestMethod]
        public void Problem2_Solution()
        {
            // By considering the terms in the Fibonacci sequence whose values do not exceed four
            // million, find the sum of the even-valued terms.
            var result = EulerProblems.Problem2Solution();

            Console.WriteLine($"Problem {2} = {result}");
            Assert.AreEqual(4613732, result);
        }

        [TestMethod]
        public void Problem3_Example()
        {
            var result = EulerProblems.Problem3Example();

            // The prime factors of 13195 are 5, 7, 13 and 29.
            Assert.AreEqual(4, result.Count);
            Assert.IsTrue(result.Contains(5));
            Assert.IsTrue(result.Contains(7));
            Assert.IsTrue(result.Contains(13));
            Assert.IsTrue(result.Contains(29));
        }

        [TestMethod]
        public void Problem3_Solution()
        {
            // What is the largest prime factor of the number 600851475143 ?
            var result = EulerProblems.Problem3Solution();

            Console.WriteLine($"Problem {3} = {result}");
            Assert.AreEqual(6857, result);
        }

        [TestMethod]
        public void Problem4_Example()
        {
            // The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
            var result = EulerProblems.Problem4Example();
            Assert.AreEqual(9009, result);
        }

        [TestMethod]
        public void Problem4_Solution()
        {
            // Find the largest palindrome made from the product of two 3-digit numbers.
            var result = EulerProblems.Problem4Solution();

            Console.WriteLine($"Problem {4} = {result}");
            Assert.AreEqual(906609, result);
        }

        [TestMethod]
        public void Problem5_Example()
        {
            // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10
            // without any remainder.
            var result = EulerProblems.Problem5Example();
            Assert.AreEqual(2520, result);
        }

        [TestMethod]
        public void Problem5_Solution()
        {
            // What is the smallest positive number that is evenly divisible by all of the numbers
            // from 1 to 20?
            var result = EulerProblems.Problem5Solution();

            Console.WriteLine($"Problem {5} = {result}");
            Assert.AreEqual(232792560, result);
        }

        [TestMethod]
        public void Problem6_Example()
        {
            // The difference between the sum of the squares of the first ten natural numbers and
            // the square of the sum is 3025 − 385 = 2640.
            var result = EulerProblems.Problem6Example();
            Assert.AreEqual(2640, result);
        }

        [TestMethod]
        public void Problem6_Solution()
        {
            // Find the difference between the sum of the squares of the first one hundred natural
            // numbers and the square of the sum.
            var result = EulerProblems.Problem6Solution();

            Console.WriteLine($"Problem {6} = {result}");
            Assert.AreEqual(25164150, result);
        }

        [TestMethod]
        public void Problem7_Example()
        {
            // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the
            // 6th prime is 13.
            var result = EulerProblems.Problem7Example();
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void Problem7_Solution()
        {
            // Find the difference between the sum of the squares of the first one hundred natural
            // numbers and the square of the sum.
            var result = EulerProblems.Problem7Solution();

            Console.WriteLine($"Problem {7} = {result}");
            Assert.AreEqual(104743, result);
        }

        [TestMethod]
        public void Problem8_Example()
        {
            // The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
            var result = EulerProblems.Problem8Example();
            Assert.AreEqual(5832, result);
        }

        [TestMethod]
        public void Problem8_Solution()
        {
            // Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
            var result = EulerProblems.Problem8Solution();

            Console.WriteLine($"Problem {8} = {result}");
            Assert.AreEqual(23514624000, result);
        }

        [TestMethod]
        public void Problem9_Solution()
        {
            // There exists exactly one Pythagorean triplet for which a + b + c = 1000.
            // Find the product abc.
            var result = EulerProblems.Problem9Solution();

            Console.WriteLine($"Problem {9} = {result}");
            Assert.AreEqual(31875000, result);
        }

        [TestMethod]
        public void Problem10_Solution()
        {
            // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
            // Find the sum of all the primes below two million.
            var result = EulerProblems.Problem10Solution();

            Console.WriteLine($"Problem {10} = {result}");
            Assert.AreEqual(142913828922, result);
        }

        [TestMethod]
        public void Problem11_Example()
        {
            // What is the greatest product of four adjacent numbers in the same direction(up,
            // down, left, right, or diagonally) in the 20×20 grid ?
            var result = EulerProblems.Problem11Example();

            Assert.AreEqual(1788696, result);
        }

        [TestMethod]
        public void Problem11_Solution()
        {
            // What is the greatest product of four adjacent numbers in the same direction(up,
            // down, left, right, or diagonally) in the 20×20 grid ?
            var result = EulerProblems.Problem11Solution();

            Console.WriteLine($"Problem {11} = {result}");
            Assert.AreEqual(70600674, result);
        }
    }
}
