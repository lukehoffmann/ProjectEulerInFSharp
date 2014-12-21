using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerInCSharp;

namespace ProjectEulerTests
{
    [TestClass]
    public class ExtensionsTests
    {
        [TestMethod]
        public void IsPalindromicTest()
        {
            Assert.IsTrue(((long)(909)).IsPalindromic());
            Assert.IsTrue(((long)(9009)).IsPalindromic());
            Assert.IsFalse(((long)(90099)).IsPalindromic());
        }
    }
}
