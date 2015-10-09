﻿namespace ProjectEulerInCSharp.Tests
{
    
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerInCSharp;

    [TestClass()]
    public class ExtensionsTests
    {
        [TestMethod()]
        public void DigitAtPositionTest()
        {
            var testString = "983475908732";
            Assert.AreEqual(7, Extensions.DigitAtPosition(testString, 4));
            Assert.AreEqual(0, Extensions.DigitAtPosition(testString, 7));
            Assert.AreEqual(8, Extensions.DigitAtPosition(testString, 1));
            Assert.AreEqual(5, Extensions.DigitAtPosition(testString, 5));
            Assert.AreEqual(9, Extensions.DigitAtPosition(testString, 6));
            Assert.AreEqual(7, Extensions.DigitAtPosition(testString, 9));
        }
    
        [TestMethod]
        public void IsPalindromicTest()
        {
            Assert.IsTrue(((int)(909)).IsPalindromic());
            Assert.IsTrue(((int)(9009)).IsPalindromic());
            Assert.IsFalse(((int)(90099)).IsPalindromic());
        }

        [TestMethod]
        public void IsPrimeTest()
        {
            Assert.IsTrue(2.IsPrime(), "2 is prime");
            Assert.IsTrue(3.IsPrime(), "3 is prime");
            Assert.IsFalse(4.IsPrime(), "4 is prime");
            Assert.IsTrue(5.IsPrime(), "5 is prime");
            Assert.IsFalse(6.IsPrime(), "6 is prime");
            Assert.IsTrue(7.IsPrime(), "7 is prime");
            Assert.IsFalse(8.IsPrime(), "8 is prime");
            Assert.IsFalse(9.IsPrime(), "9 is prime");
            Assert.IsFalse(10.IsPrime(), "10 is prime");
            Assert.IsTrue(11.IsPrime(), "11 is prime");
            Assert.IsFalse(12.IsPrime(), "12 is prime");
            Assert.IsTrue(13.IsPrime(), "13 is prime");
            Assert.IsFalse(14.IsPrime(), "14 is prime");
        }

    }
}
