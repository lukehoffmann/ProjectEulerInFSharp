using System;
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
            Assert.AreEqual(23, EulerProblems.Problem1Example());
        }

        [TestMethod]
        public void Problem1_SolutionTest()
        {
            var result = EulerProblems.Problem1Solution();

            Console.WriteLine($"Problem {1} = {result} ");
            Assert.AreEqual(233168, result);
        }

        [TestMethod]
        public void Problem2_Solution()
        {
            var result = EulerProblems.Problem2Solution();

            Console.WriteLine($"Problem {2} = {result}");
            Assert.AreEqual(4613732, result);
        }

        [TestMethod]
        public void Problem3_Example()
        {
            var result = EulerProblems.Problem3Example();

            Assert.AreEqual(4, result.Count);
            Assert.IsTrue(result.Contains(5));
            Assert.IsTrue(result.Contains(7));
            Assert.IsTrue(result.Contains(13));
            Assert.IsTrue(result.Contains(29));
        }

        [TestMethod]
        public void Problem3_Solution()
        {
            var result = EulerProblems.Problem3Solution();

            Console.WriteLine($"Problem {3} = {result}");
            Assert.AreEqual(6857, result);
        }

        [TestMethod]
        public void Problem4_Example()
        {
            Assert.AreEqual(9009, EulerProblems.Problem4Example());
        }

        [TestMethod]
        public void Problem4_Solution()
        {
            var result = EulerProblems.Problem4Solution();

            Console.WriteLine($"Problem {4} = {result}");
            Assert.AreEqual(906609, result);
        }

        [TestMethod]
        public void Problem5_Example()
        {
            Assert.AreEqual(2520, EulerProblems.Problem5Example());
        }

        [TestMethod]
        public void Problem5_Solution()
        {
            var result = EulerProblems.Problem5Solution();

            Console.WriteLine($"Problem {5} = {result}");
            Assert.AreEqual(232792560, result);
        }

        [TestMethod]
        public void Problem6_Example()
        {
            Assert.AreEqual(2640, EulerProblems.Problem6Example());
        }

        [TestMethod]
        public void Problem6_Solution()
        {
            var result = EulerProblems.Problem6Solution();

            Console.WriteLine($"Problem {6} = {result}");
            Assert.AreEqual(25164150, result);
        }

        [TestMethod]
        public void Problem7_Example()
        {
            Assert.AreEqual(13, EulerProblems.Problem7Example());
        }

        [TestMethod]
        public void Problem7_Solution()
        {
            var result = EulerProblems.Problem7Solution();

            Console.WriteLine($"Problem {7} = {result}");
            Assert.AreEqual(104743, result);
        }

        [TestMethod]
        public void Problem8_Example()
        {
            Assert.AreEqual(5832, EulerProblems.Problem8Example());
        }

        [TestMethod]
        public void Problem8_Solution()
        {
            var result = EulerProblems.Problem8Solution();

            Console.WriteLine($"Problem {8} = {result}");
            Assert.AreEqual(23514624000, result);
        }

        [TestMethod]
        public void Problem9_Solution()
        {
            var result = EulerProblems.Problem9Solution();

            Console.WriteLine($"Problem {9} = {result}");
            Assert.AreEqual(31875000, result);
        }

        [TestMethod]
        public void Problem10_Solution()
        {
            var result = EulerProblems.Problem10Solution();

            Console.WriteLine($"Problem {10} = {result}");
            Assert.AreEqual(142913828922, result);
        }

        [TestMethod]
        public void Problem11_Example()
        {
            Assert.AreEqual(1788696, EulerProblems.Problem11Example());
        }

        [TestMethod]
        public void Problem11_Solution()
        {
            var result = EulerProblems.Problem11Solution();

            Console.WriteLine($"Problem {11} = {result}");
            Assert.AreEqual(70600674, result);
        }
    }
}
