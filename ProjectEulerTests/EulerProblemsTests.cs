using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerInCSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEulerTests
{
    [TestClass]
    public class EulerProblemsTests
    {

        [TestMethod]
        public void Problem1ExampleTest()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
            //The sum of these multiples is 23.
            Int32 result = EulerProblems.Problem1Example();
            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void Problem1SolutionTest()
        {
            //Find the sum of all the multiples of 3 or 5 below 1000.
            Int32 result = EulerProblems.Problem1Solution();

            Console.WriteLine(String.Format("Problem {0} = {1} ", 1, result));
            Assert.AreEqual(233168, result);
        }

        [TestMethod]
        public void Problem2Solution()
        {
            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
            Int32 result = EulerProblems.Problem2Solution();

            Console.WriteLine(String.Format("Problem {0} = {1}", 2, result));
            Assert.AreEqual(4613732, result);
        }

        [TestMethod]
        public void Problem3Example()
        {
            List<int> result = EulerProblems.Problem3Example();

            //The prime factors of 13195 are 5, 7, 13 and 29.
            Assert.AreEqual(4, result.Count);
            Assert.IsTrue(result.Contains(5));
            Assert.IsTrue(result.Contains(7));
            Assert.IsTrue(result.Contains(13));
            Assert.IsTrue(result.Contains(29));
        }

        [TestMethod]
        public void Problem3Solution()
        {
            //What is the largest prime factor of the number 600851475143 ?
            long result = EulerProblems.Problem3Solution();

            Console.WriteLine(String.Format("Problem {0} = {1}", 3, result));
            Assert.AreEqual(6857, result);
        }

        [TestMethod]
        public void Problem4Example()
        {
            //The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
            int result = EulerProblems.Problem4Example();
            Assert.AreEqual(9009, result);
        }

        [TestMethod]
        public void Problem4Solution()
        {
            //Find the largest palindrome made from the product of two 3-digit numbers.
            int result = EulerProblems.Problem4Solution();

            Console.WriteLine(String.Format("Problem {0} = {1})", 4, result));
            Assert.AreEqual(906609, result);
        }

        [TestMethod]
        public void Problem5Example()
        {
            //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            long result = EulerProblems.Problem5Example();
            Assert.AreEqual(2520, result);
        }

        [TestMethod]
        public void Problem5Solution()
        {
            //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
            int result = EulerProblems.Problem5Solution();

            Console.WriteLine(String.Format("Problem {0} = {1})", 5, result));
            Assert.AreEqual(232792560, result);
        }

    }
}
