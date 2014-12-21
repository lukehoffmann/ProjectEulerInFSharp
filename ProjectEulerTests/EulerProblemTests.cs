using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerInCSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEulerTests
{
    [TestClass]
    public class EulerProblemTests
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
            Stopwatch watch = Stopwatch.StartNew();
            Int32 result = EulerProblems.Problem1Solution();

            watch.Stop();

            Console.WriteLine(String.Format("Problem {0} = {1}  ({2}ms)", 1, result, watch.ElapsedMilliseconds));

            Assert.AreEqual(233168, result);
        }

        [TestMethod]
        public void Problem2Solution()
        {
            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
            Stopwatch watch = Stopwatch.StartNew();
            Int32 result = EulerProblems.Problem2Solution();

            watch.Stop();
            Console.WriteLine(String.Format("Problem {0} = {1}  ({2}ms)", 2, result, watch.ElapsedMilliseconds));

            Assert.AreEqual(4613732, result);
        }

        [TestMethod]
        public void Problem3Example()
        {
            List<long> result = EulerProblems.Problem3Example();

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
            Stopwatch watch = Stopwatch.StartNew();
            long result = EulerProblems.Problem3Solution();

            watch.Stop();
            Console.WriteLine(String.Format("Problem {0} = {1}  ({2}ms)", 3, result, watch.ElapsedMilliseconds));

            Assert.AreEqual(6857, result);
        }

    }
}
