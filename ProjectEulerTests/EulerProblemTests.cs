using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerInCSharp;
using System;
using System.Diagnostics;

namespace ProjectEulerTests
{
    [TestClass]
    public class EulerProblemTests
    {
        [TestMethod]
        public void EulerProblem1Test1()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
            //The sum of these multiples is 23.
            MathHelpers euler = new MathHelpers();
            Int32 result = euler.SumOfMultiplesOfThreeOrFive(10);

            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void EulerProblem1Solution()
        {
            //Find the sum of all the multiples of 3 or 5 below 1000.
            MathHelpers euler = new MathHelpers();
            Stopwatch watch = Stopwatch.StartNew();
            Int32 result = euler.SumOfMultiplesOfThreeOrFive(1000);

            watch.Stop();

            Console.WriteLine(String.Format("Problem {0} = {1}  ({2}ms)", 1, result, watch.ElapsedMilliseconds));
           
            Assert.AreEqual(233168, result);
        }

        [TestMethod]
        public void EulerProblem2Solution()
        {
            MathHelpers euler = new MathHelpers();
           //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
            Stopwatch watch = Stopwatch.StartNew();
            Int32 result = euler.SumOfEvenFibonacciNumbers(4000000);
          
            watch.Stop();
            Console.WriteLine(String.Format("Problem {0} = {1}  ({2}ms)", 2, result, watch.ElapsedMilliseconds));

            Assert.AreEqual(4613732, result);
        }
    }
}
