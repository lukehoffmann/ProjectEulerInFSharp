namespace ProjectEulerInCSharp.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerInCSharp;

    [TestClass]
    public class EulerProblemsTests
    {

        [TestMethod]
        public void Problem1ExampleTest()
        {
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
            // The sum of these multiples is 23.
            int result = EulerProblems.Problem1Example();
            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void Problem1SolutionTest()
        {
            // Find the sum of all the multiples of 3 or 5 below 1000.
            int result = EulerProblems.Problem1Solution();

            Console.WriteLine(String.Format("Problem {0} = {1} ", 1, result));
            Assert.AreEqual(233168, result);
        }

        [TestMethod]
        public void Problem2Solution()
        {
            // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
            int result = EulerProblems.Problem2Solution();

            Console.WriteLine(String.Format("Problem {0} = {1}", 2, result));
            Assert.AreEqual(4613732, result);
        }

        [TestMethod]
        public void Problem3Example()
        {
            List<int> result = EulerProblems.Problem3Example();

            // The prime factors of 13195 are 5, 7, 13 and 29.
            Assert.AreEqual(4, result.Count);
            Assert.IsTrue(result.Contains(5));
            Assert.IsTrue(result.Contains(7));
            Assert.IsTrue(result.Contains(13));
            Assert.IsTrue(result.Contains(29));
        }

        [TestMethod]
        public void Problem3Solution()
        {
            // What is the largest prime factor of the number 600851475143 ?
            long result = EulerProblems.Problem3Solution();

            Console.WriteLine(String.Format("Problem {0} = {1}", 3, result));
            Assert.AreEqual(6857, result);
        }

        [TestMethod]
        public void Problem4Example()
        {
            // The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
            int result = EulerProblems.Problem4Example();
            Assert.AreEqual(9009, result);
        }

        [TestMethod]
        public void Problem4Solution()
        {
            // Find the largest palindrome made from the product of two 3-digit numbers.
            int result = EulerProblems.Problem4Solution();

            Console.WriteLine(String.Format("Problem {0} = {1}", 4, result));
            Assert.AreEqual(906609, result);
        }

        [TestMethod]
        public void Problem5Example()
        {
            // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            int result = EulerProblems.Problem5Example();
            Assert.AreEqual(2520, result);
        }

        [TestMethod]
        public void Problem5Solution()
        {
            // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
            int result = EulerProblems.Problem5Solution();

            Console.WriteLine(String.Format("Problem {0} = {1}", 5, result));
            Assert.AreEqual(232792560, result);
        }

        [TestMethod]
        public void Problem6Example()
        {
            // The difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
            int result = EulerProblems.Problem6Example();
            Assert.AreEqual(2640, result);
        }

        [TestMethod]
        public void Problem6Solution()
        {
            // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
            long result = EulerProblems.Problem6Solution();

            Console.WriteLine(String.Format("Problem {0} = {1}", 6, result));
            Assert.AreEqual(25164150, result);
        }

        [TestMethod]
        public void Problem7Example()
        {
            // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
            int result = EulerProblems.Problem7Example();
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void Problem7Solution()
        {
            // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
            int result = EulerProblems.Problem7Solution();

            Console.WriteLine(String.Format("Problem {0} = {1}", 7, result));
            Assert.AreEqual(104743, result);
        }

        [TestMethod]
        public void Problem8Example()
        {
            // The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
            int result = EulerProblems.Problem8Example();
            Assert.AreEqual(5832, result);
        }

        [TestMethod]
        public void Problem8Solution()
        {
            // Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
            var result = EulerProblems.Problem8Solution();

            Console.WriteLine(String.Format("Problem {0} = {1}", 8, result));
            Assert.AreEqual(23514624000, result);
        }

        [TestMethod]
        public void Problem9Solution()
        {
            // There exists exactly one Pythagorean triplet for which a + b + c = 1000.
            // Find the product abc.
            var result = EulerProblems.Problem9Solution();

            Console.WriteLine(String.Format("Problem {0} = {1}", 9, result));
            Assert.AreEqual(31875000, result);
        }

    }
}
