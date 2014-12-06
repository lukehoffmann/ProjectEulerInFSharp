using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerInCSharp;

namespace ProjectEulerTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Problem1TestControl()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
            //The sum of these multiples is 23.
            Solutions euler = new Solutions();
            Int32 result = euler.SumOfMultiplesOfThreeOrFive(10);

            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void Problem1Test()
        {
            //Find the sum of all the multiples of 3 or 5 below 1000.
            Solutions euler = new Solutions();
            Int32 result = euler.SumOfMultiplesOfThreeOrFive(1000);
            System.Diagnostics.Debug.WriteLine(result);
            Assert.AreEqual(233168, result);
        }

    }
}
